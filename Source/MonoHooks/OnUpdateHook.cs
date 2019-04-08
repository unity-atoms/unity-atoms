namespace UnityAtoms
{
    public sealed class OnUpdateHook : VoidHook
    {
        private void Update()
        {
            OnHook(new Void());
        }
    }
}
