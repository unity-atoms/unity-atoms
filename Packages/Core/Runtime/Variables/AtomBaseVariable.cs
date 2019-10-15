using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-teal")]
    public abstract class AtomBaseVariable : BaseAtom
    {
        public abstract object BaseValue { get; set; }
        public abstract void Reset(bool shouldTriggerEvents = false);
    }

    [EditorIcon("atom-icon-teal")]
    public abstract class AtomBaseVariable<T> : AtomBaseVariable
    {
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
        public virtual T Value { get { return _value; } set { throw new NotImplementedException(); } }

        [FormerlySerializedAs("value")]
        [SerializeField]
        protected T _value;

        protected bool Equals(AtomBaseVariable<T> other)
        {
            return EqualityComparer<T>.Default.Equals(_value, other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((AtomBaseVariable<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return EqualityComparer<T>.Default.GetHashCode(_value);
            }
        }
        public static bool operator ==(AtomBaseVariable<T> left, AtomBaseVariable<T> right) { return Equals(left, right); }
        public static bool operator !=(AtomBaseVariable<T> left, AtomBaseVariable<T> right) { return !Equals(left, right); }

        public override void Reset(bool shouldTriggerEvents = false)
        {
            throw new NotImplementedException();
        }
    }
}
