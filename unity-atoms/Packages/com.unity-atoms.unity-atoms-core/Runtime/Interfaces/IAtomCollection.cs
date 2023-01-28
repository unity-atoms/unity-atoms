namespace UnityAtoms
{
    /// <summary>
    /// Interface for Atom Collections.
    /// </summary>
    public interface IAtomCollection
    {
        void Add(string key, AtomBaseVariable value);
        bool Remove(string key);
    }
}