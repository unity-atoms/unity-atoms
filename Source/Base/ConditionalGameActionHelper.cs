using System;
using UnityEngine;

namespace UnityAtoms
{
    public class ConditionalGameActionHelper<T1, GA, C> where GA : GameAction<T1> where C : GameFunction<bool, T1>
    {
        [SerializeField]
        private C Condition = null;
        [SerializeField]
        private GA Action = null;
        [SerializeField]
        private VoidAction VoidAction = null;

        [SerializeField]
        private GA ElseAction = null;
        [SerializeField]
        private VoidAction ElseVoidAction = null;

        public void Do(T1 t1)
        {
            if (Condition == null || Condition.Call(t1))
            {
                if (Action != null) { Action.Do(t1); }
                if (VoidAction != null) { VoidAction.Do(); }
            }
            else
            {
                if (ElseAction != null) { ElseAction.Do(t1); }
                if (ElseVoidAction != null) { ElseVoidAction.Do(); }
            }
        }
    }

    public class ConditionalGameActionHelper<T1, T2, GA, C> where GA : GameAction<T1, T2> where C : GameFunction<bool, T1, T2>
    {
        [SerializeField]
        private C Condition = null;
        [SerializeField]
        private GA Action = null;
        [SerializeField]
        private VoidAction VoidAction = null;

        [SerializeField]
        private GA ElseAction = null;
        [SerializeField]
        private VoidAction ElseVoidAction = null;

        public void Do(T1 t1, T2 t2)
        {
            if (Condition == null || Condition.Call(t1, t2))
            {
                if (Action != null) { Action.Do(t1, t2); }
                if (VoidAction != null) { VoidAction.Do(); }
            }
            else
            {
                if (ElseAction != null) { ElseAction.Do(t1, t2); }
                if (ElseVoidAction != null) { ElseVoidAction.Do(); }
            }
        }
    }

    public class ConditionalGameActionHelper<T1, T2, T3, GA, C> where GA : GameAction<T1, T2, T3> where C : GameFunction<bool, T1, T2, T3>
    {
        [SerializeField]
        private C Condition = null;
        [SerializeField]
        private GA Action = null;
        [SerializeField]
        private VoidAction VoidAction = null;

        [SerializeField]
        private GA ElseAction = null;
        [SerializeField]
        private VoidAction ElseVoidAction = null;

        public void Do(T1 t1, T2 t2, T3 t3)
        {
            if (Condition == null || Condition.Call(t1, t2, t3))
            {
                if (Action != null) { Action.Do(t1, t2, t3); }
                if (VoidAction != null) { VoidAction.Do(); }
            }
            else
            {
                if (ElseAction != null) { ElseAction.Do(t1, t2, t3); }
                if (ElseVoidAction != null) { ElseVoidAction.Do(); }
            }
        }
    }

    public class ConditionalGameActionHelper<T1, T2, T3, T4, GA, C> where GA : GameAction<T1, T2, T3, T4> where C : GameFunction<bool, T1, T2, T3, T4>
    {
        [SerializeField]
        private C Condition = null;
        [SerializeField]
        private GA Action = null;
        [SerializeField]
        private VoidAction VoidAction = null;

        [SerializeField]
        private GA ElseAction = null;
        [SerializeField]
        private VoidAction ElseVoidAction = null;

        public void Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Condition == null || Condition.Call(t1, t2, t3, t4))
            {
                if (Action != null) { Action.Do(t1, t2, t3, t4); }
                if (VoidAction != null) { VoidAction.Do(); }
            }
            else
            {
                if (ElseAction != null) { ElseAction.Do(t1, t2, t3, t4); }
                if (ElseVoidAction != null) { ElseVoidAction.Do(); }
            }
        }
    }

    public class ConditionalGameActionHelper<T1, T2, T3, T4, T5, GA, C> where GA : GameAction<T1, T2, T3, T4, T5> where C : GameFunction<bool, T1, T2, T3, T4, T5>
    {
        [SerializeField]
        private C Condition = null;
        [SerializeField]
        private GA Action = null;
        [SerializeField]
        private VoidAction VoidAction = null;

        [SerializeField]
        private GA ElseAction = null;
        [SerializeField]
        private VoidAction ElseVoidAction = null;

        public void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (Condition == null || Condition.Call(t1, t2, t3, t4, t5))
            {
                if (Action != null) { Action.Do(t1, t2, t3, t4, t5); }
                if (VoidAction != null) { VoidAction.Do(); }
            }
            else
            {
                if (ElseAction != null) { ElseAction.Do(t1, t2, t3, t4, t5); }
                if (ElseVoidAction != null) { ElseVoidAction.Do(); }
            }
        }
    }
}
