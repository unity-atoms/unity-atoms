namespace UnityAtoms
{
    /// <summary>
    /// Interface for getting an event.
    /// </summary>
    public interface IGetEvent : ITryGetEvent
    {
        E GetEvent<E>() where E : AtomEventBase;
    }
}
