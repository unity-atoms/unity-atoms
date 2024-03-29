using System;
using System.Diagnostics;
using UnityEngine;

namespace UnityAtoms
{
    public class StackTraceEntry : IEquatable<StackTraceEntry>
    {
        private readonly Guid _id;
        private readonly int _frameCount;
        private string _stackTrace;
        private readonly object _value;
        private readonly bool _constructedWithValue = false;
        private StackTrace _trace;

        private StackTraceEntry(StackTrace trace)
        {
            _id = Guid.NewGuid();
            _trace = trace;

            if (Application.isPlaying)
            {
                _frameCount = Time.frameCount;
            }
        }

        private StackTraceEntry(string stackTrace)
        {
            _id = Guid.NewGuid();
            _stackTrace = stackTrace;

            if (Application.isPlaying)
            {
                _frameCount = Time.frameCount;
            }
        }
        private StackTraceEntry(string stackTrace, object value)
        {
            _value = value;
            _constructedWithValue = true;
            _id = Guid.NewGuid();
            _stackTrace = stackTrace;

            if (Application.isPlaying)
            {
                _frameCount = Time.frameCount;
            }
        }

        private StackTraceEntry(StackTrace trace, object value)
        {
            _value = value;
            _constructedWithValue = true;
            _id = Guid.NewGuid();
            _trace = trace;

            if (Application.isPlaying)
            {
                _frameCount = Time.frameCount;
            }
        }

#if UNITY_EDITOR
        
        public static StackTraceEntry Create<T>(T obj, int skipFrames = 0) => AtomPreferences.IsDebugModeEnabled ? new StackTraceEntry(new StackTrace(skipFrames), obj) : null;
        public static StackTraceEntry Create(int skipFrames = 0) => AtomPreferences.IsDebugModeEnabled ? new StackTraceEntry(new StackTrace(skipFrames)) : null;
        
#else
        public static StackTraceEntry Create<T>(T obj, int skipFrames = 0) => null;
        public static StackTraceEntry Create(int skipFrames = 0) => null;
#endif

        public override bool Equals(object obj) => Equals(obj as StackTraceEntry);

        public bool Equals(StackTraceEntry other) => other?._id == _id;

        public override int GetHashCode() => _id.GetHashCode();


        public override string ToString()
        {
            if (_stackTrace == null)
            {
                _stackTrace = _trace.ToString();
            }

            return _constructedWithValue
                ? $"{_frameCount}   [{(_value == null ? "null" : _value.ToString())}] {_stackTrace}"
                : $"{_frameCount} {_stackTrace}";
        }
    }
}
