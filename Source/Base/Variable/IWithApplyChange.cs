using System;

namespace UnityAtoms
{
    public interface IWithApplyChange<T, E1, E2> where T : IEquatable<T> where E1 : GameEvent<T> where E2 : GameEvent<T, T>
    {
        bool ApplyChange(T amount);
        bool ApplyChange(EquatableScriptableObjectVariable<T, E1, E2> amount);
    }
}