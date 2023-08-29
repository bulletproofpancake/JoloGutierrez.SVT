using UnityEngine.Events;

namespace SVT.References.Events
{
    public interface IEventListener
    {
        public UnityEvent Response { get; }
        public void AddListener();
        public void RemoveListener();
    }
}