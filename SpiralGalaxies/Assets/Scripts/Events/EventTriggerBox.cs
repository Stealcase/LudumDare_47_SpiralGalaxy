using Events.GameEvents;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerBox : MonoBehaviour
{
    public GameEvent triggerableEvent;

    public void OnTriggerEnter()
    {
        triggerableEvent.Raise();
    }
}
