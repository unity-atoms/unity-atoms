using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class ScriptableObjectVariableBase<T> : ScriptableObject, IWithValue<T>
    {
        public virtual T Value { get { return _value; } set { throw new NotImplementedException(); } }

        [Multiline]
        public string DeveloperDescription = "";


        [FormerlySerializedAs("value")]
        [SerializeField]
        protected T _value;

        protected bool Equals(ScriptableObjectVariableBase<T> other)
        {
            return EqualityComparer<T>.Default.Equals(_value, other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ScriptableObjectVariableBase<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return EqualityComparer<T>.Default.GetHashCode(_value);
            }
        }

        public static bool operator ==(ScriptableObjectVariableBase<T> left, ScriptableObjectVariableBase<T> right) { return Equals(left, right); }
        public static bool operator !=(ScriptableObjectVariableBase<T> left, ScriptableObjectVariableBase<T> right) { return !Equals(left, right); }
    }
}
