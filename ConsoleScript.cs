using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem;

public class ConsoleScript : MonoBehaviour
{
    public ConsoleGUIScript console;

    private BoxCollider2D boxCollider;
    private SpriteRenderer spriteRenderer;
    private ButtonControl buttonControl;
    private bool entered;
    void Start()
    {

        boxCollider = GetComponent<BoxCollider2D>();
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
            console.enableGUI();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.enabled = true;
        entered = true;

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.enabled = false;
        entered = false;
    }
}
