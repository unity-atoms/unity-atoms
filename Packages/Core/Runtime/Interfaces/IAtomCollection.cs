namespace UnityAtoms
{
    public interface IAtomCollection
    {
        void Add(string key, AtomBaseVariable value);
        bool Remove(string key);
    }
}