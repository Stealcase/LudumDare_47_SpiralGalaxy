using Assets.Scripts;
using Events.GameEvents;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float startTime = 10f;
    private float storedTime;
    public TextMeshProUGUI timerText;
    public GameEvent timeRunOut;

    // Update is called once per frame

    public void OnEnable()
    {
        storedTime = startTime;
    }
    public void ResetTime()
    {
        startTime = storedTime;
    }

    public void TimeOut()
    {
        timeRunOut.Raise();
    }
    void Update()
    {
        startTime -= Time.deltaTime;
        print(startTime);
        timerText.text = Mathf.Round(startTime).ToString();
        if (startTime < 0)
        {
            TimeOut();
        }
    }
}
