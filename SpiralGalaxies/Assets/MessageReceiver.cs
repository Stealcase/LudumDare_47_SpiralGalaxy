using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageReceiver : MonoBehaviour
{
    public Image img; 
    public TextMeshProUGUI text;
    string tryAgain = "Try Again";
    private bool isRunning = false;

    public void TryAgain()
    {
        if (!isRunning)
        {
            StartCoroutine(displayText("Try Again", 2f));
        }
    }

    public void NiceWork()
    {
        if (!isRunning)
        {
            StartCoroutine(displayText("Nice! Do it again!", 2.5f));
        }
    }

    public void Escape()
    {
        if (!isRunning)
        {
            StartCoroutine(displayText("ESCAPE!!1!1", 1.5f));
        }
    }

    public IEnumerator displayText(string displayText, float duration)
    {
        isRunning = true;
        text.text = displayText;
        img.enabled = true;
        yield return new WaitForSeconds(duration);
        img.enabled = false;
        isRunning = false;
    }
}
