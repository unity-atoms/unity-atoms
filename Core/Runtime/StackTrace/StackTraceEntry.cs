using System;
using System.Diagnostics;
using UnityEngine;

namespace UnityAtoms
{
    public class StackTraceEntry : IEquatable<StackTraceEntry>
    {
        private readonly Guid _id;
        private readonly int _frameCount;
        private readonly string _stackTrace;
        private readonly object _value;
        private readonly bool _constructedWithValue = false;

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

        public static StackTraceEntry Create(object obj, int skipFrames = 0) => new StackTraceEntry(new StackTrace(skipFrames).ToString(), obj);

        public static StackTraceEntry Create(int skipFrames = 0) => new StackTraceEntry(new StackTrace(skipFrames).ToString());


        public override bool Equals(object obj) => Equals(obj as StackTraceEntry);

        public bool Equals(StackTraceEntry other) => other?._id == _id;

        public override int GetHashCode() => _id.GetHashCode();


        public override string ToString() =>
            _constructedWithValue ?
                $"{_frameCount}   [{(_value == null ? "null" : _value.ToString())}] {_stackTrace}" :
                $"{_frameCount} {_stackTrace}";
    }
}