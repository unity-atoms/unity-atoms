using UnityEngine;

namespace UnityAtoms
{
    public class OnStartHook : VoidHook
    {
        private void Start()
        {
            OnHook(new Void());
        }
    }
}