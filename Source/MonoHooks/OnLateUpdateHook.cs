using UnityEngine;

namespace UnityAtoms
{
    public class OnLateUpdateHook : VoidHook
    {
        private void LateUpdate()
        {
            OnHook(new Void());
        }
    }
}