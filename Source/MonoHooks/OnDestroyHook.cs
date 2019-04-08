namespace UnityAtoms
{
    public sealed class OnDestroyHook : VoidHook
    {
        private void OnDestroy()
        {
            OnHook(new Void());
        }
    }
}
