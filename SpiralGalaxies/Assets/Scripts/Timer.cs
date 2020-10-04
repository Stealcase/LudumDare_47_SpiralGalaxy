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
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI attemptText;
    public GameEvent timeRunOut;

    // Update is called once per frame

    public void OnEnable()
    {
        storedTime = startTime;
        levelText.text = GameManager.currentLevel.ToString();
    }
    public void ResetTime()
    {
        startTime = storedTime;
        attemptText.text = GameManager.attemptNumber.ToString();
    }

    public void TimeOut()
    {
        timeRunOut.Raise();
    }
    void Update()
    {
        startTime -= Time.deltaTime;
        timerText.text = Mathf.Round(startTime).ToString();
        if (startTime < 0)
        {
            TimeOut();
        }
    }
}
