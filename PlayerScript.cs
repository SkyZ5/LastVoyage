using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public float jumpSpeed = 3f;

    private PlayerControls controls;
    private Vector2 moveInput;
    private Animator animator;
    private Vector2 previousPosition;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        previousPosition = rb.position;
        animator = GetComponent<Animator>();
        controls = new PlayerControls();
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Move.canceled += ctx => moveInput = Vector2.zero;
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
    }

    private void FixedUpdate()
    {
        bool isJumping = false;
        bool isMoving = false;
        Vector2 currentPosition = rb.position;

        if (previousPosition != currentPosition)
        {
            isMoving = true;
            if (previousPosition.y != currentPosition.y)
            {
                isJumping = true;
            }
            previousPosition = currentPosition;
        }
        else
        {
            isJumping = false;
            isMoving = false;
        }
        Debug.Log(moveInput + ", " + isJumping);
        
        Vector2 vector = moveInput;
        vector.y = 0;
        Debug.Log(moveInput.y);

        if (moveInput.x > 0.01f)
        {
            spriteRenderer.flipX = false; // Facing right
        }
        else if (moveInput.x < -0.01f)
        {
            spriteRenderer.flipX = true;  // Facing left
        }

        rb.transform.position = rb.position + vector * moveSpeed * Time.fixedDeltaTime;
        if (moveInput.y > 0 && !isJumping)
        {
            rb.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
            Debug.Log("ran");
        }
        
        animator.SetBool("IsMoving", isMoving);
        animator.SetBool("IsJumping", isJumping);
    }
}