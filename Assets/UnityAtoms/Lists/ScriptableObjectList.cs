using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public abstract class ScriptableObjectList<T> : ScriptableObject
    {
        [SerializeField]
        private List<T> list = new List<T>();

        protected abstract GameEvent<T> _Added { get; }
        protected abstract GameEvent<T> _Removed { get; }
        [SerializeField]
        public VoidEvent Cleared;

        public int Count { get { return list.Count; } }

        public void Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                if (null != _Added)
                {
                    _Added.Raise(item);
                }
            }
        }

        public void Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                if (null != _Removed)
                {
                    _Removed.Raise(item);
                }
            }
        }

        public void Clear()
        {
            list.Clear();
            if (null != Cleared)
            {
                Cleared.Raise();
            }
        }

        public T Get(int i)
        {
            return list[i];
        }

        public List<T> List
        {
            get { return list; }
            set { list = value; }
        }

        public T this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                list[index] = value;
            }
        }
    }
}