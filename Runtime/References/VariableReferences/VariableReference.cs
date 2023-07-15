using System;
using UnityEngine;

namespace SVT.References.VariableReferences
{
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