using System.Collections.Generic;
using UnityEngine;

namespace SVT.Runtime.EventSystem
{
    [CreateAssetMenu(menuName = "Events/Game Event")]
    public class GameEvent : ScriptableObject
    {
        private readonly List<GameEventListener> _listeners = new();

        public void RaiseEvent()
        {
            for (var i = _listeners.Count - 1; i >= 0; i--)
                _listeners[i].Response?.Invoke();
        }

        public void AddListener(GameEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(GameEventListener listener)
        {
            _listeners.Remove(listener);
        }
    }
}