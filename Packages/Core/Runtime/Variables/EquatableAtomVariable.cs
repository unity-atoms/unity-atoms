using System;

namespace UnityAtoms
{
    public abstract class EquatableAtomVariable<T, E1, E2> : AtomVariable<T, E1, E2>
        where T : IEquatable<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
    {
        protected override bool ValueEquals(T other)
        {
            return (_value == null && other == null) || (_value != null && _value.Equals(other));
        }
    }
}
