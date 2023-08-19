# Scripts for Various Things (SVT)
SVT is a compilation of things I found and written which has been useful for development in Unity.

# Features

## Variable and Bypass Variable References

Importing the namespace `SVT.References.VariableReferences` would allow you to inherit from either `VariableReference{T}` or `BypassVariableReference{T}`.
They are similar in the sense that they both store variables which allows them to be passed onto other objects,
but given the persistent nature of Scriptable Objects, any changes to a variable would be saved in the Editor.

> **Note**: I have removed the implementations of the `VariableReference` class as I believe that these implementations are not needed on every project.

### Variable Reference

```cs
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
```

The `VariableReference` class contains the following members:

|Member|Description|
|-|-|
|`T _value`|the value of the variable which we can set in the inspector and backing field of `Value`.|
|`T Value`|the public property which we use to access the value of the variable.|
|`Action <T> OnValueChanged`|the event which gets called every time the value changes.|

### Bypass Variable Reference

```cs
public abstract class BypassVariableReference<T> : ScriptableObject
{
    public event Action<T> OnValueChanged;
    public void SetValue(T value) => OnValueChanged?.Invoke(value);
}
```

The `BypassVariableReference` contains the following members:

|Member|Description|
|-|-|
|`Action <T> OnValueChanged`|the event which gets called every time the value changes.|
|`void SetValue(T value)`|the method which sets the value to be received by the listeners of `OnValueChanged`.|