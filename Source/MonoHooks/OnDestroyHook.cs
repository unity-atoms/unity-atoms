using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Destroy")]
    public sealed class OnDestroyHook : VoidHook
    {
        private void OnDestroy()
        {
            OnHook(new Void());
        }
    }
}
