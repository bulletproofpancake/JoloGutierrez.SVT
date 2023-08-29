using System;
using UnityEngine;

namespace SVT.References.Events.Generic
{
    public abstract class EventReference<T> : ScriptableObject
    {
        public event Action<T> OnEventRaised;
        public void RaiseEvent(T value) => OnEventRaised?.Invoke(value);
    }
}