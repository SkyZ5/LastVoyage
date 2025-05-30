using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class FuelScript : MonoBehaviour
{
    private int fuel;
    public TMP_Text text1;
    public TMP_Text text2;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
    public void endDay()
    {
        int random = Random.Range(1, 5);
        text2.SetText("Fuel Remaining: " + fuel + " - " + random);
        fuel -= random;
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

}
