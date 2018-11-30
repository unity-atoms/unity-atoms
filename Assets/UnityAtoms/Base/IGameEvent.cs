namespace UnityAtoms
{
    public interface IGameEvent<T>
    {
        void Raise(T item);
        void RegisterListener(IGameEventListener<T> listener);
        void UnregisterListener(IGameEventListener<T> listener);
    }


    public interface IGameEvent<T1, T2>
    {
        void Raise(T1 newItem, T2 oldItem);
    }
}