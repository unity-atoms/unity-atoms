using System;
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

        public static StackTraceEntry Create(object obj) => new StackTraceEntry(Environment.StackTrace, obj);

        public static StackTraceEntry Create() => new StackTraceEntry(Environment.StackTrace);


        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (obj is StackTraceEntry)
            {
                return Equals(obj as StackTraceEntry);
            }

            return false;
        }

        public bool Equals(StackTraceEntry other) => other._id == _id;

        public override int GetHashCode() => _id.GetHashCode();


        public override string ToString() =>
            _constructedWithValue ?
                $"{_frameCount}   [{(_value == null ? "null" : _value.ToString())}] {_stackTrace}" :
                $"{_frameCount} {_stackTrace}";

        public static implicit operator string(StackTraceEntry trace) => trace.ToString();
    }
}