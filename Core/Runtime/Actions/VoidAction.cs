namespace UnityAtoms
{
    [EditorIcon("atom-icon-purple")]
    public abstract class VoidAction : AtomAction<Void>
    {
        public override void Do(Void _)
        {
            Do();
        }

        public abstract void Do();
    }
}
