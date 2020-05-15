using System;
using UnityEngine;

namespace UnityAtoms
{
    public class StackTraceEntry : IEquatable<StackTraceEntry>
    {
        private readonly int _id;
        private readonly int _frameCount;
        private readonly string _stackTrace;
        private readonly object _value;
        private readonly bool _constructedWithValue = false;

        private StackTraceEntry(string stackTrace)
        {
            _id = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
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
            _id = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
            _stackTrace = stackTrace;

            if (Application.isPlaying)
            {
                _frameCount = Time.frameCount;
            }
        }

        public static StackTraceEntry Create(object obj)
        {
            return new StackTraceEntry(Environment.StackTrace, obj);
        }

        public static StackTraceEntry Create()
        {
            return new StackTraceEntry(Environment.StackTrace);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is StackTraceEntry)
            {
                return Equals(obj as StackTraceEntry);
            }

            return false;
        }

        public bool Equals(StackTraceEntry other)
        {
            return other._id == this._id;
        }

        public override int GetHashCode()
        {
            return _id;
        }

        public override string ToString() =>
            _constructedWithValue ?
                $"{_frameCount}   [{(_value == null ? "null" : _value.ToString())}] {_stackTrace}" :
                $"{_frameCount} {_stackTrace}";

        public static implicit operator string(StackTraceEntry trace)
        {
            return trace.ToString();
        }
    }
}