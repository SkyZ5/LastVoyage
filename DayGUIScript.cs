using UnityEngine;

public class DayGUIScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer1;
    public SpriteRenderer spriteRenderer2;
    public SpriteRenderer spriteRenderer3;
    public FoodScript food;
    public FuelScript fuel;
    public int lostFood;
    public int lostFuel;
    public bool GUIEnabled;
    void Start()
    {
        lostFood = 0; 
        lostFuel = 0;
        disableGUI();
    }

    // Update is called once per frame
    void Update()
    {
        GUIEnabled = GetComponent<Canvas>().enabled;
    }
    public bool isGUI()
    {
        return GUIEnabled;
    }
    public void enableGUI()
    {
        lostFuel = fuel.endDay();
        lostFood = food.endDay();

        GetComponent<Canvas>().enabled = true;
        spriteRenderer1.enabled = true;
        spriteRenderer2.enabled = true;
        spriteRenderer3.enabled = true;
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
        spriteRenderer1.enabled = false;
        spriteRenderer2.enabled = false;
        spriteRenderer3.enabled = false;
        food.subtractFood(lostFood);
        fuel.subtractFuel(lostFuel);
    }
}
