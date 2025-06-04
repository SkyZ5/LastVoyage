using UnityEngine;
using TMPro;

public class DayTextScript : MonoBehaviour
{
    public TMP_Text text;

    private int day;

    void Start()
    {
        text = GetComponent<TMP_Text>();
        day = 1;
        text.SetText(" Day: " + day);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getDay() { return day; }

    public void setDay(int day)
    {
        this.day = day;
        text.SetText(" Day: " + day);
    }

    public void changeText(int input)
    {
        day += input;
        text.SetText(" Day: " + day);
    }
}
