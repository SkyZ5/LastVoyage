using UnityEngine;
using TMPro;

public class GameLossScript : MonoBehaviour
{
    public FoodScript food;
    public FuelScript fuel;
    public TMP_Text daysText;
    public DayTextScript day;
    public bool GUIEnabled;
    void Start()
    {
        disableGUI();
    }

    // Update is called once per frame
    void Update()
    {
        GUIEnabled = GetComponent<Canvas>().enabled;
        if (food.getFood() <  0  || fuel.getFuel() < 0)
        {
            daysText.SetText("You Survived: " + day.getDay());
            enableGUI();
        }
    }
    public bool isGUI()
    {
        return GUIEnabled;
    }
    public void enableGUI()
    {
        GetComponent<Canvas>().enabled = true;
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
        fuel.setFuel(100);
        food.setFood(100);
        day.setDay(1);
        fuel.nextDay();
        food.nextDay();
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
