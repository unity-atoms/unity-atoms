using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for Variables. Inherits from `BaseAtom`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    public abstract class AtomBaseVariable : BaseAtom
    {
        public String Id { get => _id; set => _id = value; }

        /// <summary>
        /// The Variable value as an `object`. Beware of boxing! 🥊
        /// </summary>
        /// <value>The Variable value as an `object`.</value>
        public abstract object BaseValue { get; set; }

        [SerializeField]
        private String _id = default;

        /// <summary>
        /// Abstract method that could be implemented to reset the Variable value.
        /// </summary>
        public abstract void ResetValue(bool shouldTriggerEvents = false);
    }

    /// <summary>
    /// Generic base class for Variables. Inherits from `AtomBaseVariable`.
    /// </summary>
    /// <typeparam name="T">The Variable value type.</typeparam>
    [EditorIcon("atom-icon-teal")]
    public abstract class AtomBaseVariable<T> : AtomBaseVariable, IEquatable<AtomBaseVariable<T>>
    {
        /// <summary>
        /// The Variable value as an `object`.abstract Beware of boxing! 🥊
        /// </summary>
        /// <value>The Variable value as an `object`.</value>
        public override object BaseValue
        {
            get => _value;
            set => Value = (T)value;
        }

        /// <summary>
        /// The Variable value as a property.
        /// </summary>
        /// <returns>Get or set the Variable value.</returns>
        public virtual T Value { get => _value; set => throw new NotSupportedException($"Not supported to set value of an AtomBaseVariable<{typeof(T)}>. Did you forget to cast it to AtomVariable<{typeof(T)}> before calling this method?"); }

        [SerializeField]
        protected T _value = default(T);

        /// <summary>
        /// Determines equality between Variables.
        /// </summary>
        /// <param name="other">The other Variable to compare.</param>
        /// <returns>`true` if they are equal, otherwise `false`.</returns>
        public bool Equals(AtomBaseVariable<T> other) => other == this;


        /// <summary>
        /// Not implemented. Throws Exception
        /// </summary>
        public override void ResetValue(bool shouldTriggerEvents = false) => throw new NotSupportedException($"Not supported to reset value of an AtomBaseVariable<{typeof(T)}>. Did you forget to cast it to AtomVariable<{typeof(T)}> before calling this method?");
    }
}
