using UnityEngine.Events;

namespace SVT.References.Events.Generic
{
    public interface IEventListener<T>
    {
        public UnityEvent<T> Response { get; }
        public void AddListener();
        public void RemoveListener();
    }
}