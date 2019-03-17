using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class GameFunction<R> : ScriptableObject
    {
        public abstract R Call();
    }

    public abstract class GameFunction<R, T1> : ScriptableObject
    {
        public abstract R Call(T1 t1);
    }

    public abstract class GameFunction<R, T1, T2> : ScriptableObject
    {
        public abstract R Call(T1 t1, T2 t2);
    }

    public abstract class GameFunction<R, T1, T2, T3> : ScriptableObject
    {
        public abstract R Call(T1 t1, T2 t2, T3 t3);
    }

    public abstract class GameFunction<R, T1, T2, T3, T4> : ScriptableObject
    {
        public abstract R Call(T1 t1, T2 t2, T3 t3, T4 t4);
    }

    public abstract class GameFunction<R, T1, T2, T3, T4, T5> : ScriptableObject
    {
        public abstract R Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5);
    }
}