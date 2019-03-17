using UnityEngine;

namespace UnityAtoms
{
    public class OnUpdateHook : VoidHook
    {
        private void Update()
        {
            OnHook(new Void());
        }
    }
}