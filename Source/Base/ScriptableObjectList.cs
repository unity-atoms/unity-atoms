using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.Extensions;

namespace UnityAtoms
{
    public abstract class ScriptableObjectList<T, E> : ScriptableObject, IList<T> where E : GameEvent<T>
    {
        [SerializeField]
        private List<T> list = new List<T>();
        public E Added;
        public E Removed;
        public VoidEvent Cleared;

        public int Count => list.Count;

        public bool IsReadOnly => false;

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

        public bool Remove(T item)
        {
            var removed = list.Remove(item);
            if (!removed) return false;
            if (null != Removed)
            {
                Removed.Raise(item);
            }
            return true;
        }

        public void Clear()
        {
            list.Clear();
            if (null != Cleared)
            {
                Cleared.Raise();
            }
        }

        public bool Some(Func<T, bool> func)
        {
            return list.Some<T>(func);
        }

        public T First(Func<T, bool> func)
        {
            return list.First<T>(func);
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

        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();

        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

        public int IndexOf(T item) => list.IndexOf(item);

        public void RemoveAt(int index)
        {
            if (index >= list.Count) return;
            var item = list[index];
            list.RemoveAt(index);
            if (null != Removed)
            {
                Removed.Raise(item);
            }
        }

        public void Insert(int index, T item)
        {
            list.Insert(index, item);
            Added.Raise(item);
        }

    }
}
