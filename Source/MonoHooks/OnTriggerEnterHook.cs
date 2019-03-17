using UnityEngine;

namespace UnityAtoms
{
    public class OnTriggerEnterHook : ColliderHook
    {
        private void OnTriggerEnter(Collider other)
        {
            OnHook(other);
        }
    }
}