using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger Exit 2D")]
    public sealed class OnTriggerExit2DHook : Collider2DHook
    {
        private void OnTriggerExit2D(Collider2D other)
        {
            OnHook(other);
        }
    }
}
