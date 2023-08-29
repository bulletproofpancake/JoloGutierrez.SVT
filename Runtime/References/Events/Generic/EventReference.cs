using System;
using UnityEngine;

namespace SVT.References.Events.Generic
{
    public abstract class EventReference<T> : ScriptableObject
    {
        public event Action<T> OnEventRaise;
        public void RaiseEvent(T value) => OnEventRaise?.Invoke(value);
    }
}