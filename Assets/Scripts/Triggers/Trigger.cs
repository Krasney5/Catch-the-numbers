using UnityEngine;

namespace Triggers
{
    [RequireComponent(typeof(Collider2D))]
    public class Trigger<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected virtual void OnEnter(T triggered) { }

        protected virtual void OnExit(T triggered) { }

        protected virtual void OnStay(T triggered) { }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other != null)
            {
                if (other.TryGetComponent(out T triggered))
                {
                    OnEnter(triggered);
                }
            }
        }

        private void OnTriggerStay2D(Collider2D other)
        {
            if (other != null)
            {
                if (other.TryGetComponent(out T triggered))
                {
                    OnStay(triggered);
                }
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other != null)
            {
                if (other.TryGetComponent(out T triggered))
                {
                    OnExit(triggered);
                }
            }
        }
    }
}