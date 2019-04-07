using UnityEngine;

namespace UnityAtoms
{
    public sealed class OnTriggerStayHook : ColliderHook
    {
        private void OnTriggerStay(Collider other)
        {
            OnHook(other);
        }
    }
}
