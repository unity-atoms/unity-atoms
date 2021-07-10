namespace UnityAtoms
{
    /// <summary>
    /// Used to specify if Atoms need to manage in-memory lifetime of a variable or an event
    /// </summary>
    public enum Scope
    {
        Global,
        Scene,
        Unmanaged
    }
}
