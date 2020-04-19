using System;

namespace UnityAtoms
{
    /// <summary>
    /// Atom Variable base class for types that are implementing `IEquatable&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The Variable type.</typeparam>
    /// <typeparam name="P">Pair of type T.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Pair event of type T.</typeparam>
    /// <typeparam name="F">Function of type T and T.</typeparam>
    [EditorIcon("atom-icon-lush")]
    public abstract class EquatableAtomVariable<T, P, E1, E2, F> : AtomVariable<T, P, E1, E2, F>
        where T : IEquatable<T>
        where P : struct, IPair<T>
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
