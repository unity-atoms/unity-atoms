namespace UnityAtoms
{
    /// <summary>
    /// Interface for trying to get an event.
    /// Used in references, where the underlying object may not always support events.
    /// </summary>
    public interface ITryGetEvent
    {
        bool TryGetEvent<E>(out E atomEvent) where E : AtomEventBase;
    }
}
