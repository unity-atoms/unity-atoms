namespace UnityAtoms
{
    public interface IGetEvent
    {
        E GetEvent<E>() where E : AtomEventBase;
    }
}