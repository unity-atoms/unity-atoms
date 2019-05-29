using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger Enter")]
    public sealed class OnTriggerEnterHook : ColliderHook
    {
        private void OnTriggerEnter(Collider other)
        {
            OnHook(other);
        }
    }
}
