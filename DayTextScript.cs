using UnityEngine;
using TMPro;

public class DayTextScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int day;
    private TMP_Text text;

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

    public void changeText()
    {
        day++;
        text.SetText(" Day: " + day);
    }
}
