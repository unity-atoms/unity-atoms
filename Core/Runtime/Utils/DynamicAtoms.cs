using System;
using UnityEngine;

namespace UnityAtoms
{
    public static class DynamicAtoms
    {
        public static V CreateVariable<T, V, E1, E2>(T initialValue, E1 changed = null, E2 changedWithHistory = null)
            where V : AtomVariable<T, E1, E2>
            where E1 : AtomEvent<T> where E2 : AtomEvent<T, T>
        {
            var sov = ScriptableObject.CreateInstance<V>();
            sov.Changed = changed;
            sov.ChangedWithHistory = changedWithHistory;
            sov.Value = initialValue;
            return sov;
        }

        public static L CreateList<T, L, E>(E added = null, E removed = null, VoidEvent cleared = null)
            where L : AtomList<T, E>
            where E : AtomEvent<T>
        {
            var sol = ScriptableObject.CreateInstance<L>();
            sol.Added = added;
            sol.Removed = removed;
            sol.Cleared = cleared;
            return sol;
        }

        public static GA CreateAction<GA, T1>(Action<T1> action)
            where GA : AtomAction<T1>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        public static GA CreateAction<GA, T1, T2>(Action<T1, T2> action)
            where GA : AtomAction<T1, T2>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        public static GA CreateAction<GA, T1, T2, T3>(Action<T1, T2, T3> action)
            where GA : AtomAction<T1, T2, T3>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        public static GA CreateAction<GA, T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
            where GA : AtomAction<T1, T2, T3, T4>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        public static GA CreateAction<GA, T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
            where GA : AtomAction<T1, T2, T3, T4, T5>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        public static GF CreateFunction<GF, R>(Func<R> func)
            where GF : AtomFunction<R>
        {
            var gf = ScriptableObject.CreateInstance<GF>();
            gf.Func = func;
            return gf;
        }

        public static GF CreateFunction<GF, R, T1>(Func<T1, R> func)
            where GF : AtomFunction<R, T1>
        {
            var gf = ScriptableObject.CreateInstance<GF>();
            gf.Func = func;
            return gf;
        }

        public static GF CreateFunction<GF, R, T1, T2>(Func<T1, T2, R> func)
            where GF : AtomFunction<R, T1, T2>
        {
            var gf = ScriptableObject.CreateInstance<GF>();
            gf.Func = func;
            return gf;
        }

        public static GF CreateFunction<GF, R, T1, T2, T3>(Func<T1, T2, T3, R> func)
            where GF : AtomFunction<R, T1, T2, T3>
        {
            var gf = ScriptableObject.CreateInstance<GF>();
            gf.Func = func;
            return gf;
        }

        public static GF CreateFunction<GF, R, T1, T2, T3, T4>(Func<T1, T2, T3, T4, R> func)
            where GF : AtomFunction<R, T1, T2, T3, T4>
        {
            var gf = ScriptableObject.CreateInstance<GF>();
            gf.Func = func;
            return gf;
        }

        public static GF CreateFunction<GF, R, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, R> func)
            where GF : AtomFunction<R, T1, T2, T3, T4, T5>
        {
            var gf = ScriptableObject.CreateInstance<GF>();
            gf.Func = func;
            return gf;
        }
    }
}
