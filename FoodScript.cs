using TMPro;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
    public TMP_Text text1;
    public TMP_Text text2;

    private int food;
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
    public int endDay()
    {
        int random = Random.Range(1, 5);
        text2.SetText("Food Remaining: " + food + " - " + random);
        return random;
    }
    public void nextDay()
    {
        text1.SetText("" + food);
        text2.SetText("Food Remaining: " + food);
    }
    public void addFood(int input)
    {
        food += input;
        nextDay();
    }
    public void subtractFood(int input)
    {
        food -= input;
        nextDay();
    }
    public int getFood()
    {
        return food;
    }

    public void setFood(int input) {
        food = input; 
    }

}
