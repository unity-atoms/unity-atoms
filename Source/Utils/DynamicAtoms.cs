using UnityEngine;

namespace UnityAtoms.Utils
{
    public static class DynamicAtoms
    {
        public static V CreateVariable<T, V, E1, E2>(T initialValue, E1 changed = null, E2 changedWithHistory = null)
            where V : ScriptableObjectVariable<T, E1, E2>
            where E1 : GameEvent<T> where E2 : GameEvent<T, T>
        {
            var sov = ScriptableObject.CreateInstance<V>();
            sov.Changed = changed;
            sov.ChangedWithHistory = changedWithHistory;
            sov.Value = initialValue;
            return sov;
        }

        public static L CreateList<T, L, E>(E added = null, E removed = null, VoidEvent cleared = null)
            where L : ScriptableObjectList<T, E>
            where E : GameEvent<T>
        {
            var sol = ScriptableObject.CreateInstance<L>();
            sol.Added = added;
            sol.Removed = removed;
            sol.Cleared = cleared;
            return sol;
        }
    }
}
