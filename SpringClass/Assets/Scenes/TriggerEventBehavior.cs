using UnityEngine;
using UnityEngine.Events;

namespace Scenes
{
    public class TriggerEventBehavior : MonoBehaviour
    {
        public UnityEvent triggerEnterEvent;

        private void OnTriggerEnter(Collider other)
        {
            triggerEnterEvent.Invoke();
        }
    }
}