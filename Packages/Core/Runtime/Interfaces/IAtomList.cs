namespace UnityAtoms
{
    public interface IAtomList
    {
        void Add(AtomBaseVariable item);
        bool Remove(AtomBaseVariable item);
    }
}