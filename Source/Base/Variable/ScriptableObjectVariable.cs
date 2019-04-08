using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class ScriptableObjectVariable<T, E1, E2> : ScriptableObjectVariableBase<T>,
        IWithOldValue<T>
        where E1 : GameEvent<T>
        where E2 : GameEvent<T, T>
    {
        public override T Value { get { return _runtimeValue; } set { SetValue(value); } }

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
            if (!AreEqual(this._runtimeValue, newValue))
            {
                this._initialValue = this._runtimeValue;
                this._runtimeValue = newValue;
                if (Changed != null) { Changed.Raise(newValue); }
                if (ChangedWithHistory != null) { ChangedWithHistory.Raise(this._runtimeValue, this._oldValue); }
                return true;
            }

            return false;
        }

        public bool SetValue(ScriptableObjectVariable<T, E1, E2> variable)
        {
            return SetValue(variable.Value);
        }
    }
}
