namespace UnityAtoms
{
    /// <summary>
    /// Interface defining a generic `IPair&lt;T&gt;`.
    /// </summary>
    public interface IPair<T>
    {
        T Value { get; set; }
        T OldValue { get; set; }

        void Deconstruct(out T Value, out T OldValue);
    }
}
