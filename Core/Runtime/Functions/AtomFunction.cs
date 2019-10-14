using System;
using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R> : BaseAtom, IAtomFunctionIcon
    {
        [HideInInspector]
        public Func<R> Func;

        public virtual R Call()
        {
            if (Func != null)
            {
                return Func();
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        public AtomFunction<R> SetFunc(Func<R> func)
        {
            Func = func;
            return this;
        }
    }

    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1> : BaseAtom, IAtomFunctionIcon
    {
        [HideInInspector]
        public Func<T1, R> Func;

        public virtual R Call(T1 t1)
        {
            if (Func != null)
            {
                return Func(t1);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        public AtomFunction<R, T1> SetFunc(Func<T1, R> func)
        {
            Func = func;
            return this;
        }
    }

    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2> : BaseAtom, IAtomFunctionIcon
    {
        [HideInInspector]
        public Func<T1, T2, R> Func;

        public virtual R Call(T1 t1, T2 t2)
        {
            if (Func != null)
            {
                return Func(t1, t2);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        public AtomFunction<R, T1, T2> SetFunc(Func<T1, T2, R> func)
        {
            Func = func;
            return this;
        }
    }

    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2, T3> : BaseAtom, IAtomFunctionIcon
    {
        [HideInInspector]
        public Func<T1, T2, T3, R> Func;

        public virtual R Call(T1 t1, T2 t2, T3 t3)
        {
            if (Func != null)
            {
                return Func(t1, t2, t3);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        public AtomFunction<R, T1, T2, T3> SetFunc(Func<T1, T2, T3, R> func)
        {
            Func = func;
            return this;
        }
    }

    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2, T3, T4> : BaseAtom, IAtomFunctionIcon
    {
        [HideInInspector]
        public Func<T1, T2, T3, T4, R> Func;

        public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Func != null)
            {
                return Func(t1, t2, t3, t4);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        public AtomFunction<R, T1, T2, T3, T4> SetFunc(Func<T1, T2, T3, T4, R> func)
        {
            Func = func;
            return this;
        }
    }

    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2, T3, T4, T5> : BaseAtom, IAtomFunctionIcon
    {
        [HideInInspector]
        public Func<T1, T2, T3, T4, T5, R> Func;

        public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (Func != null)
            {
                return Func(t1, t2, t3, t4, t5);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        public AtomFunction<R, T1, T2, T3, T4, T5> SetFunc(Func<T1, T2, T3, T4, T5, R> func)
        {
            Func = func;
            return this;
        }
    }
}
