﻿using UnityEngine.Events;

 namespace Events.GameEvents
{
    public class Events
    {
        
    }
    [System.Serializable]
    public class StringEvent : UnityEvent<string>{}
    
    [System.Serializable]
    public class BoolEvent : UnityEvent<bool>{}
    
}