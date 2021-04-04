namespace UnityAtoms
{
    /// <summary>
    /// Struct defining a generic `Pair&lt;T&gt;`.
    /// </summary>
    public struct Pair<T>
    {
        public T Item1 { get; set; }
        public T Item2 { get; set; }

        public void Deconstruct(out T item1, out T item2) { item1 = Item1; item2 = Item2; }
    }
}
