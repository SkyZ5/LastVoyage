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
    }

    // Update is called once per frame
    void Update()
    {
        text1.SetText("" + fuel);
        text2.SetText("Fuel Remaining: " + fuel);
    }
    public void endDay()
    {
        int random = Random.Range(1, 5);
        fuel -= random;
    }
}
