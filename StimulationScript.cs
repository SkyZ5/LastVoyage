using UnityEngine;
using UnityEngine.InputSystem;

public class StimulationScript : MonoBehaviour
{
    public bool GUIEnabled;
    void Start()
    {
        disableGUI();
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
    public void enableGUI()
    {
        GetComponent<Canvas>().enabled = true;
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
