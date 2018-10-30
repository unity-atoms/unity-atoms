using UnityEngine;

namespace UnityAtoms
{
    public class OnTriggerEnter2DHook : Collider2DHook
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            OnHook(other);
        }
    }
}