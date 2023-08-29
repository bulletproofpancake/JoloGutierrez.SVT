using UnityEngine.Events;

namespace SVT.References.Events
{
    public interface IEventListener
    {
        public EventReference Event { get; }
        public UnityEvent Response { get; }
        public void OnEventRaise();
        public void AddListener(UnityAction call);
        public void RemoveListener(UnityAction call);
    }
}