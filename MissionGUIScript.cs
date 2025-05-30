using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MissionGUIScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool GUIEnabled;
    public TMP_Text food;
    public TMP_Text fuel;
    public FoodScript foodScript;
    public FuelScript fuelScript;
    private int foodObtained;
    private int fuelCost;
    void Start()
    {
        disableGUI();
        food.SetText("food obtained: "  );
        fuel.SetText("fuel consumed: ");
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
    public void enableGUI(int days)
    {
        GetComponent<Canvas>().enabled = true;
        foodObtained = Random.Range(days, days * 5);
        fuelCost = Random.Range(days * 2, days * 6);
        food.SetText("food obtained: " + foodObtained);
        fuel.SetText("fuel consumed: " + fuelCost);
    }
    public void continueButton()
    {
        disableGUI();
        foodScript.addFood(foodObtained);
        fuelScript.subtractFuel(fuelCost);
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
