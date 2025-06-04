using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class FuelScript : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;

    private int fuel;

    void Start()
    {
        fuel = 100;
        text1.SetText("" + fuel);
        text2.SetText("Fuel Remaining: " + fuel);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public int endDay()
    {
        int random = Random.Range(1, 5);
        text2.SetText("Fuel Remaining: " + fuel + " - " + random);
        return random;
    }
    public void nextDay()
    {
        text1.SetText("" + fuel);
        text2.SetText("Fuel Remaining: " + fuel);
    }
    public void addFuel(int input)
    {
        fuel += input;
        nextDay();
    }
    public void subtractFuel(int input)
    {
        fuel -= input;
        nextDay();
    }
    public int getFuel() 
    {
        return fuel; 
    }

    public void setFuel(int input)
    {
        fuel = input; 
    }

}
