namespace UnityAtoms
{
    public interface IAtomListener
    {
        void OnEventRaised();
    }

    public interface IAtomListener<T>
    {
        void OnEventRaised(T item);
    }

    public interface IAtomListener<T1, T2>
    {
        void OnEventRaised(T1 first, T2 second);
    }
}
