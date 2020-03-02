namespace UnityAtoms
{
    /// <summary>
    /// Action of type `Void`. Inherits from `AtomAction&lt;Void&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    public abstract class VoidAction : AtomAction<Void>
    {
        /// <summary>
        /// Do the Action.
        /// </summary>
        /// <param name="_">Dummy Void parameter.</param>
        public override void Do(Void _)
        {
            Do();
        }
    }
}
