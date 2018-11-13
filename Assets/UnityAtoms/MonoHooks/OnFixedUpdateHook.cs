using UnityEngine;

namespace UnityAtoms
{
    public class OnFixedUpdateHook : VoidHook
    {
        private void FixedUpdate()
        {
            OnHook(new Void());
        }
    }
}