using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class for Variables. Inherits from `BaseAtom`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    public abstract class AtomBaseVariable : BaseAtom
    {
        /// <summary>
        /// The Variable value as an `object`.abstract Beware of boxing! 🥊
        /// </summary>
        /// <value>The Variable value as an `object`.</value>
        public abstract object BaseValue { get; set; }

        /// <summary>
        /// Abstract method that could be implemented to reset the Variable value.
        /// </summary>
        public abstract void Reset(bool shouldTriggerEvents = false);
    }

    /// <summary>
    /// Generic base class for Variables. Inherits from `AtomBaseVariable`.
    /// </summary>
    /// <typeparam name="T">The Variable value type.</typeparam>
    [EditorIcon("atom-icon-teal")]
    public abstract class AtomBaseVariable<T> : AtomBaseVariable
    {
        /// <summary>
        /// The Variable value as an `object`.abstract Beware of boxing! 🥊
        /// </summary>
        /// <value>The Variable value as an `object`.</value>
        public override object BaseValue
        {
            get
            {
                return _value;
            }
            set
            {
                Value = (T)value;
            }
        }

        /// <summary>
        /// The Variable value as a property.
        /// </summary>
        /// <returns>Get or set the Variable value.</returns>
        public virtual T Value { get { return _value; } set { throw new NotImplementedException(); } }

        [SerializeField]
        protected T _value;

        protected bool Equals(AtomBaseVariable<T> other)
        {
            return EqualityComparer<T>.Default.Equals(_value, other._value);
        }

        /// <summary>
        /// Determines equality between Variables.
        /// </summary>
        /// <param name="obj">The other Variable to compare as an `object`.</param>
        /// <returns>`true` if they are equal, otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AtomBaseVariable<T>)obj);
        }

        /// <summary>
        /// Get an unique hash code for this Variable based on the Variable's value.
        /// </summary>
        /// <returns>An unique hash.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                return EqualityComparer<T>.Default.GetHashCode(_value);
            }
        }

        /// <summary>
        /// Equal operator.
        /// </summary>
        /// <param name="left">The first Variable to compare.</param>
        /// <param name="right">The second Variable to compare.</param>
        /// <returns>`true` if eqaul, otherwise `false`.</returns>
        public static bool operator ==(AtomBaseVariable<T> left, AtomBaseVariable<T> right) { return Equals(left, right); }

        /// <summary>
        /// None equality operator.
        /// </summary>
        /// <param name="left">The first Variable to compare.</param>
        /// <param name="right">The second Variable to compare.</param>
        /// <returns>`true` if not eqaul, otherwise `false`.</returns>
        public static bool operator !=(AtomBaseVariable<T> left, AtomBaseVariable<T> right) { return !Equals(left, right); }

        /// <summary>
        /// Not implemented.abstract Throws Exception
        /// </summary>
        public override void Reset(bool shouldTriggerEvents = false)
        {
            throw new NotImplementedException();
        }
    }
}
