using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using AC;

public class TimeCounter : MonoBehaviour
{
    public int stringVariableNumber = 6; // to put here the number of the correct variable (in case the order is changing)
    public int integerVariableNumber = 3;

    public string gameTime;
    // public TextMeshProUGUI mainClock;
    public string myFormat = "dd hh:mm:ss";

    
    public System.TimeSpan timeSpan = new System.TimeSpan(0, 0, 0, 0, 0);
    public System.DateTime date = new System.DateTime(2022, 01, 01);
    public float timeRate = 1;

    private int gameTimeUnified;

    // Update is called once per frame
    private void Update()
    {
        float milliseconds = Time.deltaTime * 1000 * timeRate;

        timeSpan += new System.TimeSpan(0, 0, 0, 0, (int)milliseconds);
        System.DateTime dateTime = System.DateTime.MinValue.Add(timeSpan);

        gameTime = dateTime.ToString(@myFormat);
        gameTimeUnified = System.Int32.Parse(dateTime.ToString("ddhhmm"));
        // mainClock.text = gameTime;

        AC.GlobalVariables.SetStringValue(stringVariableNumber, gameTime); // sets the string value
        AC.GlobalVariables.SetIntegerValue(integerVariableNumber, gameTimeUnified); // sets the integer value



    }

public void AddTime(int value)
    {
        timeSpan += new System.TimeSpan(0, value, 0);
    }
}
