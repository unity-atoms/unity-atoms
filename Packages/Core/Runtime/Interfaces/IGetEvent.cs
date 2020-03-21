namespace UnityAtoms
{
    /// <summary>
    /// Interface for getting an event.
    /// </summary>
    public interface IGetEvent
    {
        E GetEvent<E>() where E : AtomEventBase;
    }
}