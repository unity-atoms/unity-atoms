namespace UnityAtoms
{
    public abstract class VoidAction : GameAction<Void>
    {
        public override void Do(Void _)
        {
            Do();
        }

        public abstract void Do();
    }
}