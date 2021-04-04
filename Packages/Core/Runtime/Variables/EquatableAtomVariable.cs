using System;

namespace UnityAtoms
{
    /// <summary>
    /// Atom Variable base class for types that are implementing `IEquatable&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The Variable type.</typeparam>
    [EditorIcon("atom-icon-lush")]
    public abstract class EquatableAtomVariable<T> : AtomVariable<T> where T : IEquatable<T>
    {
        protected override bool ValueEquals(T other)
        {
            return (_value == null && other == null) || (_value?.Equals(other) == true);
        }
    }
}
