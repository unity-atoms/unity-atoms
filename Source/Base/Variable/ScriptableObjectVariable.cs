using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class ScriptableObjectVariable<T, E1, E2> : ScriptableObjectVariableBase<T>,
        IWithOldValue<T>,
        ISerializationCallbackReceiver
        where E1 : GameEvent<T>
        where E2 : GameEvent<T, T>
    {
        public override T Value { get { return _value; } set { SetValue(value); } }

        [SerializeField]
        private T _initialValue;

        public T OldValue { get { return _oldValue; } }

        [FormerlySerializedAs("oldValue")]
        [SerializeField]
        private T _oldValue;

        public E1 Changed;

        public E2 ChangedWithHistory;

        protected abstract bool AreEqual(T first, T second);

        private void OnEnable()
        {
            if (Changed == null) return;
            Changed.Raise(Value);
        }

        public bool SetValue(T newValue)
        {
            if (!AreEqual(_value, newValue))
            {
                _oldValue = _value;
                _value = newValue;
                if (Changed != null) { Changed.Raise(_value); }
                if (ChangedWithHistory != null) { ChangedWithHistory.Raise(_value, _oldValue); }
                return true;
            }

            return false;
        }

        public bool SetValue(ScriptableObjectVariable<T, E1, E2> variable)
        {
            return SetValue(variable.Value);
        }

        public void OnBeforeSerialize() { }
        public void OnAfterDeserialize() { _value = _initialValue; }
    }
}
