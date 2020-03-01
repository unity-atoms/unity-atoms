using System;

namespace UnityAtoms
{
    public abstract class EquatableAtomVariable<T, P, E1, E2, F> : AtomVariable<T, P, E1, E2, F>
        where T : IEquatable<T>
        where P : unmanaged, IPair<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
    {
        protected override bool ValueEquals(T other)
        {
            return (_value == null && other == null) || (_value != null && _value.Equals(other));
        }
    }
}
