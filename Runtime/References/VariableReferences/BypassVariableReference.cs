using System;
using UnityEngine;

namespace SVT.References.VariableReferences
{
    /// <summary>
    /// Similar to <see cref="VariableReference{T}"/>
    /// except it does not hold any value.
    /// </summary>
    public abstract class BypassVariableReference<T> : ScriptableObject
    {
        public event Action<T> OnValueChanged;
        public void SetValue(T value) => OnValueChanged?.Invoke(value);
    }
}