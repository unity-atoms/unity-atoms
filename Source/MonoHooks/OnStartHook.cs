namespace UnityAtoms
{
    public sealed class OnStartHook : VoidHook
    {
        private void Start()
        {
            OnHook(new Void());
        }
    }
}
