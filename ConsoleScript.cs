using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem;

public class ConsoleScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ConsoleGUIScript console;
    private BoxCollider2D BoxCollider;
    private SpriteRenderer spriteRenderer;
    private ButtonControl buttonControl;
    private bool entered;
    void Start()
    {

        BoxCollider = GetComponent<BoxCollider2D>();
        buttonControl = new ButtonControl();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        entered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.isPressed && entered)
        {
            Debug.Log("AAAAAAAAAAAAA");
            console.enableGUI();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("ran");
        spriteRenderer.enabled = true;
        entered = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.enabled = false;
        entered = false;
    }
}
