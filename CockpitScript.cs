using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class CockpitScript : MonoBehaviour
{
    public DayTextScript text;
    public DayGUIScript DayGUI;
    public PlayerScript player;
    public FuelScript fuel;
    public FoodScript food;
    public int day = 1;

    private bool entered;
    private bool GUIEnabled;
    private BoxCollider2D boxCollider;
    private SpriteRenderer spriteRenderer;
    private ButtonControl buttonControl;
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
        GUIEnabled = DayGUI.isGUI();
        if (Keyboard.current.eKey.isPressed && entered && !player.isGUIEnabled() && !GUIEnabled)
        {
            day++;
            text.changeText(1);
            DayGUI.enableGUI();
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
    public int getDays()
    { 
        return day; 
    }
}
