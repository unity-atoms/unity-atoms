using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class ScriptableObjectVariableBase<T> : ScriptableObject, IWithValue<T>, ISerializationCallbackReceiver
    {
        public virtual T Value { get { return _runtimeValue; } set { throw new NotImplementedException(); } }

        [Multiline]
        public string DeveloperDescription = "";


        [FormerlySerializedAs("value")]
        [SerializeField] protected T _initialValue;
        [NonSerialized] protected T _runtimeValue;

        protected bool Equals(ScriptableObjectVariableBase<T> other) {
            return EqualityComparer<T>.Default.Equals(_runtimeValue, other._runtimeValue);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ScriptableObjectVariableBase<T>) obj);
        }

        public override int GetHashCode() {
            unchecked {
                return EqualityComparer<T>.Default.GetHashCode(_runtimeValue);
            }
        }

        public static bool operator ==(ScriptableObjectVariableBase<T> left, ScriptableObjectVariableBase<T> right) { return Equals(left, right); }
        public static bool operator !=(ScriptableObjectVariableBase<T> left, ScriptableObjectVariableBase<T> right) { return !Equals(left, right); }

        public void OnBeforeSerialize() {  }
        public void OnAfterDeserialize() { _runtimeValue = _initialValue; }
    }
}
