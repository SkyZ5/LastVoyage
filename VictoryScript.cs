using UnityEngine;

public class VictoryScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool GUIEnabled;
    public DayTextScript day;
    void Start()
    {
        disableGUI();
    }

    // Update is called once per frame
    void Update()
    {
        GUIEnabled = GetComponent<Canvas>().enabled;
        if (day.getDay() == 200)
        {
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
    }
}
