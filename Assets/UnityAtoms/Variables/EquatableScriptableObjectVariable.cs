using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public abstract class EquatableScriptableObjectVariable<T, E1, E2> : ScriptableObjectVariable<T, E1, E2> where T : IEquatable<T> where E1 : GameEvent<T> where E2 : GameEvent<T, T>
    {
        protected override bool AreEqual(T t1, T t2)
        {
            return t1.Equals(t2);
        }
    }
}