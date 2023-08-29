using UnityEngine.Events;

namespace SVT.References.Events.Generic
{
    public interface IEventListener<T>
    {
        public EventReference<T> Event { get; }
        public UnityEvent<T> Response { get; }
        public void OnEventRaise(T value);
        public void AddListener(UnityAction<T> call);
        public void RemoveListener(UnityAction<T> call);
    }
}