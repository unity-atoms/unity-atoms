namespace UnityAtoms
{
    public interface IGameEventListener<T>
    {
        void OnEventRaised(T item);
    }

    public interface IGameEventListener<T1, T2>
    {
        void OnEventRaised(T1 first, T2 second);
    }
}