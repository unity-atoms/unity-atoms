using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Trigger Stay")]
    public sealed class OnTriggerStayHook : ColliderHook
    {
        private void OnTriggerStay(Collider other)
        {
            OnHook(other);
        }
    }
}
