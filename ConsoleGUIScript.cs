using System;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class ConsoleGUIScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool GUIEnabled;
    public TMP_Text food;
    public TMP_Text fuel;
    public TMP_Text error;
    public InputField inputField;
    private int days;
    void Start()
    {
        disableGUI();
        days = 0;
        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
        error.SetText("");
        food.SetText("possible food: 0");
        fuel.SetText("fuel consumed: 0");
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
    void OnInputFieldValueChanged(string input  )
    {
        error.SetText("");
        try
        {
            Debug.Log(input);
            days = Int32.Parse(input);
            food.SetText("possible food: " + days + " - " + days * 5);
            fuel.SetText("fuel consumed: " + days * 2);

        }
        catch 
        {
            error.SetText("NOT A VALID INPUT");
        }
    }
}
