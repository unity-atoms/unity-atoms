using System;

namespace UnityAtoms
{
    public abstract class EquatableAtomVariable<T, E1, E2, F> : AtomVariable<T, E1, E2, F>
        where T : IEquatable<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
    {
        protected override bool AreEqual(T t1, T t2)
        {
            return (t1 == null && t2 == null) || (t1 != null && t1.Equals(t2));
        }
    }
}
