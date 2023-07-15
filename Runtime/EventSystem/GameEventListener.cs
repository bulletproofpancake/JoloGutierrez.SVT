using UnityEngine;
using UnityEngine.Events;

namespace SVT.Runtime.EventSystem
{
    public class GameEventListener : MonoBehaviour
    {
        [field: SerializeField] public GameEvent Event { get; private set; }
        [field: SerializeField] public UnityEvent Response { get; private set; }

        private void OnEnable()
        {
            Event.AddListener(this);
        }

        private void OnDisable()
        {
            Event.RemoveListener(this);
        }
    }
}