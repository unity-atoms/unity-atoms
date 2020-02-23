using System;

namespace UnityAtoms
{
    public abstract class EquatableAtomReference<T, C, V, E1, E2, F, VI> : AtomReference<T, C, V, E1, E2, F, VI>, IEquatable<EquatableAtomReference<T, C, V, E1, E2, F, VI>>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, T, E1, E2, F>
    {
        public bool Equals(EquatableAtomReference<T, C, V, E1, E2, F, VI> other) { return base.Equals(other); }

        protected override bool ValueEquals(T other)
        {
            return (Value == null && other == null) || (Value != null && Value.Equals(other));
        }
    }
}
