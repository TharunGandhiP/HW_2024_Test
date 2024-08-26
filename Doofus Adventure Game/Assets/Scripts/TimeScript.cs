using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeScript : MonoBehaviour
{
    [SerializeField] TMP_Text Timer;
    [SerializeField] float remainingTime;
    void Update()
    {
        UpdateTimerText();
    }
    void UpdateTimerText()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
        }

        int T = Mathf.FloorToInt((remainingTime % 10) * 100);
        int sec = Mathf.FloorToInt(T / 100);
        int mili = Mathf.FloorToInt(T % 100);
        Timer.text = string.Format("{0:0}:{1:00}", sec, mili);
    }
}
