using System;

namespace UnityAtoms
{
    public abstract class EquatableAtomVariable<T, E1, E2> : AtomVariable<T, E1, E2>
        where T : IEquatable<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
    {
        protected override bool AreEqual(T t1, T t2)
        {
            return (t1 == null && t2 == null) || (t1 != null && t1.Equals(t2));
        }
    }
}
