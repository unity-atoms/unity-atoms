using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Hooks/On Update")]
    public sealed class OnUpdateHook : VoidHook
    {
        private void Update()
        {
            OnHook(new Void());
        }
    }
}
