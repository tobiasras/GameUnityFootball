using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float startTime;
    private float currentTime = 0f; 
    public TextMeshProUGUI timerText;
    public float CurrentTime => currentTime;

    private void Start()
    {

        if (PlayerPrefs.HasKey("Time"))
        {
            startTime = PlayerPrefs.GetFloat("Time");
            currentTime = startTime;
        }
        else
        {
            startTime = 0;
            currentTime = 0;
        }
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        timerText.text = "Current Time: " + currentTime.ToString("F2") + " seconds";

    }
}
