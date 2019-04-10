namespace UnityAtoms
{
    public sealed class OnFixedUpdateHook : VoidHook
    {
        private void FixedUpdate()
        {
            OnHook(new Void());
        }
    }
}
