namespace UnityAtoms
{
    public interface ISetEvent
    {
        void SetEvent<E>(E e) where E : AtomEventBase;
    }
}