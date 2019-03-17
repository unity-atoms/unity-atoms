using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Utils
{
    public static class DynamicAtoms
    {
        public static V CreateVariable<T, V, E1, E2>(bool createChangedEvent = true, bool createChangedWithHistoryEvent = false) where V : ScriptableObjectVariable<T, E1, E2> where E1 : GameEvent<T> where E2 : GameEvent<T, T>
        {
            var sov = ScriptableObject.CreateInstance<V>();
            sov.Changed = createChangedEvent ? ScriptableObject.CreateInstance<E1>() : null;
            sov.ChangedWithHistory = createChangedWithHistoryEvent ? ScriptableObject.CreateInstance<E2>() : null;
            return sov;
        }

        public static L CreateList<T, L, E>(bool createAddedEvent = false, bool createRemovedEvent = false, bool createClearedEvent = false) where L : ScriptableObjectList<T, E> where E : GameEvent<T>
        {
            var sol = ScriptableObject.CreateInstance<L>();
            sol.Added = createAddedEvent ? ScriptableObject.CreateInstance<E>() : null;
            sol.Removed = createRemovedEvent ? ScriptableObject.CreateInstance<E>() : null;
            sol.Cleared = createClearedEvent ? ScriptableObject.CreateInstance<VoidEvent>() : null;
            return sol;
        }
    }
}