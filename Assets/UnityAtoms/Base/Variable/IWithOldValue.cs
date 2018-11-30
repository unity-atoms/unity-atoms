namespace UnityAtoms
{
    public interface IWithOldValue<T>
    {
        T OldValue { get; }
    }
}