using UnityEngine;

namespace UnityAtoms
{
    public sealed class OnTriggerExit2DHook : Collider2DHook
    {
        private void OnTriggerExit2D(Collider2D other)
        {
            OnHook(other);
        }
    }
}
