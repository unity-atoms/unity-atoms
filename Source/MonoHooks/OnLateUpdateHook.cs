using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Late Update")]
    public sealed class OnLateUpdateHook : VoidHook
    {
        private void LateUpdate()
        {
            OnHook(new Void());
        }
    }
}
