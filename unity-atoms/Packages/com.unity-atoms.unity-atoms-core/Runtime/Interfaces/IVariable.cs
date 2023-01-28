namespace UnityAtoms
{
    /// <summary>
    /// Interface for retrieving a Variable.
    /// </summary>
    public interface IVariable<T>
    {
        T Variable { get; }
    }
}