using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Start")]
    public sealed class OnStartHook : VoidHook
    {
        private void Start()
        {
            OnHook(new Void());
        }
    }
}
