namespace UnityAtoms
{
    /// <summary>
    /// Interface for getting or creating an event.
    /// </summary>
    public interface IGetOrCreateEvent
    {
        E GetOrCreateEvent<E>() where E : AtomEventBase;
    }
}