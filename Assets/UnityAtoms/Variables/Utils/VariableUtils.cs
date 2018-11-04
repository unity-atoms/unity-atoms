using UnityEngine;

namespace UnityAtoms
{
    public static class VariableUtils
    {
        public static V CreateVariable<T, V, E1, E2>(bool createChangedEvent = true, bool createChangedWithHistoryEvent = false) where V : ScriptableObjectVariable<T, E1, E2> where E1 : GameEvent<T> where E2 : GameEvent<T, T>
        {
            var sov = ScriptableObject.CreateInstance<V>();
            sov.Changed = createChangedEvent ? ScriptableObject.CreateInstance<E1>() : null;
            sov.ChangedWithHistory = createChangedWithHistoryEvent ? ScriptableObject.CreateInstance<E2>() : null;
            return sov;
        }
    }
}
