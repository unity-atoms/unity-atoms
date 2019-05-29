using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger Enter 2D")]
    public sealed class OnTriggerEnter2DHook : Collider2DHook
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            OnHook(other);
        }
    }
}
