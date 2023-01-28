#if UNITY_EDITOR
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace UnityAtoms
{
    public static class StackTraces
    {
        private static Dictionary<int, ObservableCollection<StackTraceEntry>> _stackTracesById = new Dictionary<int, ObservableCollection<StackTraceEntry>>();

        public static void AddStackTrace(int id, StackTraceEntry stackTrace)
        {
            if (AtomPreferences.IsDebugModeEnabled)
            {
                GetStackTraces(id).Insert(0, stackTrace);
            }
        }

        public static void ClearStackTraces(int id) => GetStackTraces(id).Clear();

        public static ObservableCollection<StackTraceEntry> GetStackTraces(int id)
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
