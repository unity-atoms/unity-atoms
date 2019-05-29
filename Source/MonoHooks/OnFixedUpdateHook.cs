using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Fixed Update")]
    public sealed class OnFixedUpdateHook : VoidHook
    {
        private void FixedUpdate()
        {
            OnHook(new Void());
        }
    }
}
