using UnityEngine;
using UnityEngine.InputSystem;

public class EscapeMenu : MonoBehaviour
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
        if (Keyboard.current.escapeKey.isPressed)
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

    public void exitButton()
    {
        Application.Quit();
    }
    public void continueButton()
    {
        disableGUI();
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
