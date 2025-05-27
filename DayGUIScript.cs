using UnityEngine;

public class DayGUIScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
