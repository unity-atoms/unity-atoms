using UnityEngine;

namespace UnityAtoms
{
    public class OnTriggerStay2DHook : Collider2DHook
    {
        private void OnTriggerStay2D(Collider2D other)
        {
            OnHook(other);
        }
    }
}