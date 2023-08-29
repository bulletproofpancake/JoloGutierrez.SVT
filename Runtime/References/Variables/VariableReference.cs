using System;
using UnityEngine;

namespace SVT.References.Variables
{
    /// <summary>
    /// Holds a value and invokes an event when it is changed.
    /// </summary>
    public abstract class VariableReference<T> : ScriptableObject
    {
        [SerializeField] protected T _value;

        public T Value
        {
            get => _value;
            set
            {
                _value = value;
                OnValueChanged?.Invoke(_value);
            }
        }

        public event Action<T> OnValueChanged;
    }
}