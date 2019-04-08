using UnityEngine;

namespace UnityAtoms
{
    public sealed class OnTriggerEnterHook : ColliderHook
    {
        private void OnTriggerEnter(Collider other)
        {
            OnHook(other);
        }
    }
}
