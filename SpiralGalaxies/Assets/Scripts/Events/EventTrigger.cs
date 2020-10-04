using UnityEngine;

namespace Events.GameEvents
{
    public class EventTrigger : MonoBehaviour
    {
        public GameEvent localEvent;

        public void OnEventTrigger()
        {
            localEvent.Raise();
        }
    }
}