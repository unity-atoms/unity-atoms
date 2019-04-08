using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    [Serializable]
    public abstract class ConditionalGameActionHelper<T1, GA, C>
        where GA : GameAction<T1>
        where C : GameFunction<bool, T1>
    {
        [FormerlySerializedAs("Condition")]
        [SerializeField]
        private C _condition = null;

        [FormerlySerializedAs("Action")]
        [SerializeField]
        private GA _action = null;

        [FormerlySerializedAs("VoidAction")]
        [SerializeField]
        private VoidAction _voidAction = null;

        [FormerlySerializedAs("ElseAction")]
        [SerializeField]
        private GA _elseAction = null;

        [FormerlySerializedAs("ElseVoidAction")]
        [SerializeField]
        private VoidAction _elseVoidAction = null;

        public void Do(T1 t1)
        {
            if (_condition == null || _condition.Call(t1))
            {
                if (_action != null) { _action.Do(t1); }
                if (_voidAction != null) { _voidAction.Do(); }
            }
            else
            {
                if (_elseAction != null) { _elseAction.Do(t1); }
                if (_elseVoidAction != null) { _elseVoidAction.Do(); }
            }
        }
    }

    [Serializable]
    public abstract class ConditionalGameActionHelper<T1, T2, GA, C>
        where GA : GameAction<T1, T2>
        where C : GameFunction<bool, T1, T2>
    {
        [SerializeField]
        private C _condition;

        [SerializeField]
        private GA _action;

        [SerializeField]
        private VoidAction _voidAction;

        [SerializeField]
        private GA _elseAction;

        [SerializeField]
        private VoidAction _elseVoidAction;

        public void Do(T1 t1, T2 t2)
        {
            if (_condition == null || _condition.Call(t1, t2))
            {
                if (_action != null) { _action.Do(t1, t2); }
                if (_voidAction != null) { _voidAction.Do(); }
            }
            else
            {
                if (_elseAction != null) { _elseAction.Do(t1, t2); }
                if (_elseVoidAction != null) { _elseVoidAction.Do(); }
            }
        }
    }

    [Serializable]
    public abstract class ConditionalGameActionHelper<T1, T2, T3, GA, C>
        where GA : GameAction<T1, T2, T3>
        where C : GameFunction<bool, T1, T2, T3>
    {
        [SerializeField]
        private C _condition = null;

        [SerializeField]
        private GA _action = null;

        [SerializeField]
        private VoidAction _voidAction = null;

        [SerializeField]
        private GA _elseAction = null;

        [SerializeField]
        private VoidAction _elseVoidAction = null;

        public void Do(T1 t1, T2 t2, T3 t3)
        {
            if (_condition == null || _condition.Call(t1, t2, t3))
            {
                if (_action != null) { _action.Do(t1, t2, t3); }
                if (_voidAction != null) { _voidAction.Do(); }
            }
            else
            {
                if (_elseAction != null) { _elseAction.Do(t1, t2, t3); }
                if (_elseVoidAction != null) { _elseVoidAction.Do(); }
            }
        }
    }

    [Serializable]
    public abstract class ConditionalGameActionHelper<T1, T2, T3, T4, GA, C>
        where GA : GameAction<T1, T2, T3, T4>
        where C : GameFunction<bool, T1, T2, T3, T4>
    {
        [SerializeField]
        private C _condition = null;

        [SerializeField]
        private GA _action = null;

        [SerializeField]
        private VoidAction _voidAction = null;

        [SerializeField]
        private GA _elseAction = null;

        [SerializeField]
        private VoidAction _elseVoidAction = null;

        public void Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (_condition == null || _condition.Call(t1, t2, t3, t4))
            {
                if (_action != null) { _action.Do(t1, t2, t3, t4); }
                if (_voidAction != null) { _voidAction.Do(); }
            }
            else
            {
                if (_elseAction != null) { _elseAction.Do(t1, t2, t3, t4); }
                if (_elseVoidAction != null) { _elseVoidAction.Do(); }
            }
        }
    }

    [Serializable]
    public abstract class ConditionalGameActionHelper<T1, T2, T3, T4, T5, GA, C>
        where GA : GameAction<T1, T2, T3, T4, T5>
        where C : GameFunction<bool, T1, T2, T3, T4, T5>
    {
        [SerializeField]
        private C _condition = null;

        [SerializeField]
        private GA _action = null;

        [SerializeField]
        private VoidAction _voidAction = null;

        [SerializeField]
        private GA _elseAction = null;

        [SerializeField]
        private VoidAction _elseVoidAction = null;

        public void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (_condition == null || _condition.Call(t1, t2, t3, t4, t5))
            {
                if (_action != null) { _action.Do(t1, t2, t3, t4, t5); }
                if (_voidAction != null) { _voidAction.Do(); }
            }
            else
            {
                if (_elseAction != null) { _elseAction.Do(t1, t2, t3, t4, t5); }
                if (_elseVoidAction != null) { _elseVoidAction.Do(); }
            }
        }
    }
}
