using System;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class AtomAction<T1> : ScriptableObject, IAtomActionIcon
    {
        [HideInInspector]
        public Action<T1> Action;

        public virtual void Do(T1 t1)
        {
            if (Action != null)
            {
                Action(t1);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    public abstract class AtomAction<T1, T2> : ScriptableObject, IAtomActionIcon
    {
        [HideInInspector]
        public Action<T1, T2> Action;

        public virtual void Do(T1 t1, T2 t2)
        {
            if (Action != null)
            {
                Action(t1, t2);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    public abstract class AtomAction<T1, T2, T3> : ScriptableObject, IAtomActionIcon
    {
        [HideInInspector]
        public Action<T1, T2, T3> Action;

        public virtual void Do(T1 t1, T2 t2, T3 t3)
        {
            if (Action != null)
            {
                Action(t1, t2, t3);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    public abstract class AtomAction<T1, T2, T3, T4> : ScriptableObject, IAtomActionIcon
    {
        [HideInInspector]
        public Action<T1, T2, T3, T4> Action;

        public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Action != null)
            {
                Action(t1, t2, t3, t4);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    public abstract class AtomAction<T1, T2, T3, T4, T5> : ScriptableObject, IAtomActionIcon
    {
        [HideInInspector]
        public Action<T1, T2, T3, T4, T5> Action;

        public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (Action != null)
            {
                Action(t1, t2, t3, t4, t5);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }
}
