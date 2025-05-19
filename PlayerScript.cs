using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    private PlayerControls controls;
    private Vector2 moveInput;
    private Animator animator;
    private Vector2 previousPosition;

    private void Awake()
    {
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
        bool isMoving = false;
        Vector2 currentPosition = rb.position;
        if (previousPosition != currentPosition)
        {
            isMoving = true;
            previousPosition = currentPosition;
        }
        else
        {
            isMoving = false;
        }

        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        // bool isMoving = rb.linearVelocity.x >= 0.01f;
        Debug.Log(isMoving + ", " + previousPosition + ", " + currentPosition);
        animator.SetBool("IsMoving", isMoving);
    }
}