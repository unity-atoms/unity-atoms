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

        private void OnEnable()
        {
            if (Changed == null) return;
            Changed.Raise(Value);
        }

        public bool SetValue(T newValue)
        {
            if (!AreEqual(value, newValue))
            {
                oldValue = value;
                value = newValue;
                if (Changed != null) { Changed.Raise(newValue); }
                if (ChangedWithHistory != null) { ChangedWithHistory.Raise(value, oldValue); }
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
