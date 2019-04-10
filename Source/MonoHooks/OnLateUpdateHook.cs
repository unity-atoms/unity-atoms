namespace UnityAtoms
{
    public sealed class OnLateUpdateHook : VoidHook
    {
        private void LateUpdate()
        {
            OnHook(new Void());
        }
    }
}
