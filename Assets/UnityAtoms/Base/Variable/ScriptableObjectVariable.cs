using System;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class ScriptableObjectVariable<T, E1, E2> : ScriptableObjectVariableBase<T>, IWithOldValue<T> where E1 : GameEvent<T> where E2 : GameEvent<T, T>
    {
        public override T Value { get { return value; } set { SetValue(value); } }

        public T OldValue { get { return oldValue; } }

        [SerializeField]
        private T oldValue;

        public E1 Changed;

        public E2 ChangedWithHistory;

        protected abstract bool AreEqual(T first, T second);

        public bool SetValue(T value)
        {
            if (!AreEqual(this.value, value))
            {
                this.oldValue = this.value;
                this.value = value;
                if (Changed != null) { Changed.Raise(value); }
                if (ChangedWithHistory != null) { ChangedWithHistory.Raise(this.value, this.oldValue); }
            }

            return true;
        }

        public bool SetValue(ScriptableObjectVariable<T, E1, E2> variable)
        {
            return SetValue(variable.Value);
        }
    }
}