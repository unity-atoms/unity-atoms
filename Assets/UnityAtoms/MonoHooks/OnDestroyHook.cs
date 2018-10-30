using UnityEngine;

namespace UnityAtoms
{
    public class OnDestroyHook : VoidHook
    {
        private void OnDestroy()
        {
            OnHook(new Void());
        }
    }
}