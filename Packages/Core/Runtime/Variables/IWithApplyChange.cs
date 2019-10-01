using System;

namespace UnityAtoms
{
    public interface IWithApplyChange<T, E1, E2>
        where T : IEquatable<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
    {
        bool ApplyChange(T amount);
        bool ApplyChange(EquatableAtomVariable<T, E1, E2> amount);
    }
}
