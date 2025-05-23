using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class CockpitScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private BoxCollider2D BoxCollider;
    private SpriteRenderer spriteRenderer;
    private ButtonControl buttonControl;
    public DayTextScript text;
    private bool entered;
    public int day = 1;
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
            Debug.Log("PPPPPPPP");
            day++;
            Debug.Log($"{day}");
            text.changeText();
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
    public int getDays()
    { 
        return day; 
    }
}
