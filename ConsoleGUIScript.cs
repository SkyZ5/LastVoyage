using System;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class ConsoleGUIScript : MonoBehaviour
{
    public bool GUIEnabled;
    public TMP_Text food;
    public TMP_Text fuel;
    public TMP_Text error;
    public InputField inputField;
    public DayTextScript day;
    public MissionGUIScript mission;

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
        inputField.enabled = true;
        GetComponent<Canvas>().enabled = true;
    }
    public void disableGUI()
    {
        inputField.enabled = false;
        GetComponent<Canvas>().enabled = false;
    }
    void OnInputFieldValueChanged(string input)
    {
        error.SetText("");
        try
        {
            Debug.Log(input);
            days = Int32.Parse(input);
            food.SetText("possible food: " + days + " - " + days * 5);
            fuel.SetText("fuel consumed: " + days * 2 + " - " + days * 6);

        }
        catch 
        {
            error.SetText("NOT A VALID INPUT");
        }
    }
    public void continueButton()
    {
        day.changeText(days);
        mission.enableGUI(days);
    }
}
