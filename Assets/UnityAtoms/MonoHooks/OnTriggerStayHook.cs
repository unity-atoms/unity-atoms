using UnityEngine;

namespace UnityAtoms
{
    public class OnTriggerStayHook : ColliderHook
    {
        private void OnTriggerStay(Collider other)
        {
            OnHook(other);
        }
    }
}