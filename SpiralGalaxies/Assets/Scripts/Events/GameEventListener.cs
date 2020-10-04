using UnityEngine;
using UnityEngine.Events;
namespace Events.GameEvents
{
    public class GameEventListener : MonoBehaviour
    {
        [Tooltip("Event to register with.")]
        public GameEvent Event;

        [Tooltip("Response to invoke when Event is raised.")]
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            if(Response!= null) //Making sure that we don't throw a nullreferenceException error
                Response.Invoke();
            else
                Debug.Log("Couldn't respond to event call with " + this.gameObject + "because there is no assigned response");
        }
    }
}