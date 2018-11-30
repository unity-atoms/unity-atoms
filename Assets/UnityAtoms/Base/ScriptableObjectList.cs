using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public abstract class ScriptableObjectList<T, E> : ScriptableObject where E : GameEvent<T>
    {
        [SerializeField]
        private List<T> list = new List<T>();
        public E Added;
        public E Removed;
        public VoidEvent Cleared;

        public int Count { get { return list.Count; } }

        public void Add(T item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                if (null != Added)
                {
                    Added.Raise(item);
                }
            }
        }

        public void Remove(T item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                if (null != Removed)
                {
                    Removed.Raise(item);
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

        public bool Contains(T item)
        {
            return list.Contains(item);
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