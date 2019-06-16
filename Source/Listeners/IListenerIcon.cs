namespace UnityAtoms
{
    /// <summary>
    /// Use in order to determine if this is a Listener when assigning icons to Atoms.
    /// This is hack is necessary because IsAssignableFrom and IsSubclassOf doesn't work without a type constraint 💩
    /// </summary>
    public interface IListenerIcon { }
}
