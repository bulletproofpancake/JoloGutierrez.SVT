using System;
using UnityEngine;

namespace SVT.References.Events
{
    [CreateAssetMenu(menuName = "SVT/References/Events/Event Reference")]
    public class EventReference : ScriptableObject
    {
        public event Action OnEventRaise;
        public void RaiseEvent() => OnEventRaise?.Invoke();
    }
}