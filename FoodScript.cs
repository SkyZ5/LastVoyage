using TMPro;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    private int food;
    public TMP_Text text1;
    public TMP_Text text2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        food = 100;
        text1.SetText("" + food);
        text2.SetText("Food Remaining: " + food);
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void endDay()
    {
        int random = Random.Range(1, 5);
        text2.SetText("Food Remaining: " + food + " - " + random);
        food -= random;
    }
    public void nextDay()
    {
        text1.SetText("" + food);
        text2.SetText("Food Remaining: " + food);
    }
}
