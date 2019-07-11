using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;

    private void Update()
    {
        if (SaveValues.timeLeft > 6000)
        {
            timerText.text = "Time: " + Convert.ToInt32((SaveValues.timeLeft + Time.deltaTime) / 100.0 / 60.0) + " Min.";
        } else
        {
            timerText.text = "Time: " + Convert.ToInt32((SaveValues.timeLeft + Time.deltaTime) / 100.0) + " Sek.";
        }
        SaveValues.timeLeft = SaveValues.timeLeft - (1 + Time.deltaTime);
    }
}
