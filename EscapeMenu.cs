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
            Debug.Log("YO");
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
        Debug.Log("YOO");
        Application.Quit();
    }
    public void continueButton()
    {
        Debug.Log("YOOOOO");
        disableGUI();
    }
    public void disableGUI()
    {
        GetComponent<Canvas>().enabled = false;
    }
}
