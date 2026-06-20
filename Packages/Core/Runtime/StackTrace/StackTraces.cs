#if UNITY_EDITOR
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Collections.Generic;

#if !UNITY_6000_3_OR_NEWER
using EntityId = System.Int32;
#endif

namespace UnityAtoms
{
    public static class StackTraces
    {
        private static Dictionary<EntityId, ObservableCollection<StackTraceEntry>> _stackTracesById = new Dictionary<EntityId, ObservableCollection<StackTraceEntry>>();

        public static void AddStackTrace(EntityId id, StackTraceEntry stackTrace)
        {
            if (stackTrace == null) return;
            if (AtomPreferences.IsDebugModeEnabled)
            {
                GetStackTraces(id).Insert(0, stackTrace);
            }
        }     

        public static void ClearStackTraces(EntityId id) => GetStackTraces(id).Clear();

        public static ObservableCollection<StackTraceEntry> GetStackTraces(EntityId id)
        {
            if (!_stackTracesById.ContainsKey(id))
            {
                _stackTracesById.Add(id, new ObservableCollection<StackTraceEntry>());
            }
            else if (_stackTracesById[id] == null)
            {
                _stackTracesById[id] = new ObservableCollection<StackTraceEntry>();
            }

            return _stackTracesById[id];
        }
    }
}
#endif
