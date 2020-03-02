using System;

namespace UnityAtoms
{
    public abstract class EquatableAtomReference<T, P, C, V, E1, E2, F, VI, CO, L> : AtomReference<T, P, C, V, E1, E2, F, VI, CO, L>, IEquatable<EquatableAtomReference<T, P, C, V, E1, E2, F, VI, CO, L>>
        where P : struct, IPair<T>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, P, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, P, T, E1, E2, F, CO, L>
        where CO : IGetValue<IAtomCollection>
        where L : IGetValue<IAtomList>
    {
        public EquatableAtomReference() : base() { }
        public EquatableAtomReference(T value) : base(value) { }
        public bool Equals(EquatableAtomReference<T, P, C, V, E1, E2, F, VI, CO, L> other) { return base.Equals(other); }

        protected override bool ValueEquals(T other)
        {
            return (Value == null && other == null) || (Value != null && Value.Equals(other));
        }
    }
}
