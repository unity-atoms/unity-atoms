namespace UnityAtoms
{
    /// <summary>
    /// Interface defining a generic `IPair&lt;T&gt;`.
    /// </summary>
    public interface IPair<T>
    {
        T Item1 { get; set; }
        T Item2 { get; set; }

        void Deconstruct(out T item1, out T item2);
    }
}
