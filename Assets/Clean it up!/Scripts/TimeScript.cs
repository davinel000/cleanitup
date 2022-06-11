using TMPro;
using UnityEngine;
using System.Globalization;

public class TimeScript : MonoBehaviour
{
    public string myFormat;

    public TextMeshProUGUI mainClock;

    public System.TimeSpan timeSpan = new System.TimeSpan(2024,05,01);

    public System.DateTime date = new System.DateTime();

    public float timeRate = 1;
    

    private void Update()
    {
        float milliseconds = Time.deltaTime * 1000 * timeRate;

        timeSpan += new System.TimeSpan(0, 0, 0, 0, (int)milliseconds);
        System.DateTime dateTime = System.DateTime.MinValue.Add(timeSpan);

        mainClock.text = dateTime.ToString(@myFormat, CultureInfo.GetCultureInfo("en-UK"));

    }

    public void AddTime(int value)
    {
        timeSpan += new System.TimeSpan(0, value, 0);
    }

}
