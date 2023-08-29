using SVT.References.Events.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SVT.References.Events.Generic
{
    public abstract class EventListener<T> : MonoBehaviour, IEventListener<T>
    {
        [field: SerializeField] public EventReference<T> Event { get; protected set; }
        [field: SerializeField] public UnityEvent<T> Response { get; protected set; }

        protected virtual void OnEnable()
        {
            Event.OnEventRaise += OnEventRaise;
        }

        protected virtual void OnDisable()
        {
            Event.OnEventRaise -= OnEventRaise;
        }

        public void AddListener(UnityAction<T> call)
        {
            Response.AddListener(call);
        }

        public void OnEventRaise(T value)
        {
            Response?.Invoke(value);
        }

        public void RemoveListener(UnityAction<T> call)
        {
            Response.RemoveListener(call);
        }
    }
}