using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger Stay 2D")]
    public sealed class OnTriggerStay2DHook : Collider2DHook
    {
        private void OnTriggerStay2D(Collider2D other)
        {
            OnHook(other);
        }
    }
}
