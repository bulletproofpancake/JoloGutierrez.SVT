using System;
using UnityEngine;

namespace SVT.References.Events
{
    public class EventReference : ScriptableObject
    {
        public event Action OnEventRaise;
        public void RaiseEvent() => OnEventRaise?.Invoke();
    }
}