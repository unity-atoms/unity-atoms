namespace UnityAtoms
{
    /// <summary>
    /// Interface for trying to get or create an event.
    /// Used in references, where the underlying object may not always support events.
    /// </summary>
    public interface ITryGetOrCreateEvent
    {
        bool TryGetOrCreateEvent<E>(out E atomEvent) where E : AtomEventBase;
    }
}
