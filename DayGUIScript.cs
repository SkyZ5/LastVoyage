using UnityEngine;

public class DayGUIScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SpriteRenderer SpriteRenderer1;
    public SpriteRenderer SpriteRenderer2;
    public SpriteRenderer SpriteRenderer3;
    public FoodScript Food;
    public FuelScript Fuel;
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
        lostFuel = Fuel.endDay();
        lostFood = Food.endDay();

        GetComponent<Canvas>().enabled = true;
        SpriteRenderer1.enabled = true;
        SpriteRenderer2.enabled = true;
        SpriteRenderer3.enabled = true;
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
        SpriteRenderer1.enabled = false;
        SpriteRenderer2.enabled = false;
        SpriteRenderer3.enabled = false;
        Food.subtractFood(lostFood);
        Fuel.subtractFuel(lostFuel);
    }
}
