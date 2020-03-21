using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// A Serializable dictionary used by AtomCollection.
    /// </summary>
    /// <typeparam name="K">Key type.</typeparam>
    /// <typeparam name="V">Value type.</typeparam>
    [Serializable]
    public abstract class SerializableDictionary<K, V> : IDictionary<K, V>, ISerializationCallbackReceiver, IEnumerable<KeyValuePair<K, V>>, IEnumerable, ICollection<KeyValuePair<K, V>>
        where K : IEquatable<K>
    {
        public Action<V> Added { get => _added; set => _added = value; }
        public Action<V> Removed { get => _removed; set => _removed = value; }
        public Action Cleared { get => _cleared; set => _cleared = value; }

        private event Action<V> _added;
        private event Action<V> _removed;
        private event Action _cleared;

        private Dictionary<K, V> _dict = new Dictionary<K, V>();

        [SerializeField]
        private List<K> _serializedKeys = new List<K>();
        [SerializeField]
        private List<V> _serializedValues = new List<V>();

        /// <summary>
        /// Needed in order to keep track of duplicate keys in the dictionary.
        /// </summary>
        /// <typeparam name="int"></typeparam>
        /// <returns></returns>
        [SerializeField]
        private List<int> _duplicateKeyIndices = new List<int>();

        public void OnAfterDeserialize()
        {
            if (_serializedKeys != null && _serializedValues != null)
            {
                var keyCount = _serializedKeys.Count;
                var valueCount = _serializedValues.Count;

                // This is a precaution and might not be necessay. However, we make sure that _serializedKeys have the same length as _serializedValues. 
                // Everything is assuming that the lists are in sync. The larger list will be reduced in length to the same as the smaller of the 2.
                if (keyCount != valueCount)
                {
                    if (keyCount > valueCount)
                    {
                        _serializedKeys.RemoveRange(valueCount, keyCount - valueCount);
                    }
                    else
                    {
                        _serializedValues.RemoveRange(keyCount, valueCount - keyCount);
                    }
                }

                _dict.Clear();
                _duplicateKeyIndices.Clear();
                var length = _serializedKeys.Count;
                for (var i = 0; i < length; ++i)
                {
                    if (!_dict.ContainsKey(_serializedKeys[i]))
                    {
                        _dict.Add(_serializedKeys[i], _serializedValues[i]);
                    }
                    else
                    {
                        _duplicateKeyIndices.Add(i);
                    }
                }
            }
        }

        public void OnBeforeSerialize()
        {
            var enumerator = _dict.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    var keyIndex = _serializedKeys.IndexOf(enumerator.Current.Key);
                    if (keyIndex != -1)
                    {
                        _serializedKeys[keyIndex] = enumerator.Current.Key;
                        _serializedValues[keyIndex] = enumerator.Current.Value;
                    }
                    else
                    {
                        _serializedKeys.Add(enumerator.Current.Key);
                        _serializedValues.Add(enumerator.Current.Value);
                    }
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        #region IDictionary<K, V>
        public ICollection<K> Keys { get => _dict.Keys; }
        public ICollection<V> Values { get => _dict.Values; }
        public int Count { get => _dict.Count; }
        public bool IsReadOnly { get => false; }
        public V this[K key]
        {
            get => _dict[key];
            set => _dict[key] = value;
        }

        public void Add(K key, V value)
        {
            if (ContainsKey(key)) return;
            _dict.Add(key, value);
            _serializedKeys.Add(key);
            _serializedValues.Add(value);
            _added?.Invoke(value);
        }

        public void Add(KeyValuePair<K, V> kvp)
        {
            Add(kvp.Key, kvp.Value);
        }

        public bool ContainsKey(K key) { return _dict.ContainsKey(key); }

        public bool Remove(K key)
        {
            if (!_dict.ContainsKey(key)) return false;

            var value = _dict[key];
            _dict.Remove(key);
            var index = _serializedKeys.IndexOf(key);
            _serializedKeys.RemoveAt(index);
            _serializedValues.RemoveAt(index);
            _removed?.Invoke(value);
            return true;
        }

        public bool Remove(KeyValuePair<K, V> kvp)
        {
            return Remove(kvp.Key);
        }

        public bool TryGetValue(K key, out V value) { return _dict.TryGetValue(key, out value); }

        public void Clear()
        {
            _dict.Clear();
            _cleared?.Invoke();
        }

        public bool Contains(KeyValuePair<K, V> kvp)
        {
            V value;
            return _dict.TryGetValue(kvp.Key, out value) && value.Equals(kvp.Value);
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }

            if (index < 0 || index > array.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            var enumerator = _dict.GetEnumerator();
            var cur = 0;
            try
            {
                while (enumerator.MoveNext())
                {
                    if (cur >= index)
                    {
                        array[cur] = new KeyValuePair<K, V>(enumerator.Current.Key, enumerator.Current.Value);
                    }
                    ++cur;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator() { return _dict.GetEnumerator(); }

        IEnumerator IEnumerable.GetEnumerator() { return _dict.GetEnumerator(); }

        #endregion
    }
}