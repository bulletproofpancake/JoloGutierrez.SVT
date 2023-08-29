using UnityEngine;
using UnityEngine.Events;

namespace SVT.References.Events
{
    public class EventListener : MonoBehaviour, IEventListener
    {
        [field: SerializeField] public EventReference Event { get; protected set; }
        [field: SerializeField] public UnityEvent Response { get; protected set; }

        protected virtual void OnEnable()
        {
            Event.OnEventRaise += OnEventRaise;
        }

        protected virtual void OnDisable()
        {
            Event.OnEventRaise -= OnEventRaise;
        }
        public void AddListener(UnityAction call)
        {
            Response.AddListener(call);
        }

        public void OnEventRaise()
        {
            Response?.Invoke();
        }

        public void RemoveListener(UnityAction call)
        {
            Response.RemoveListener(call);
        }
    }

}