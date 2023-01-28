using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// A SerializableDictionary of type StringReference and AtomBaseVariable. Used by AtomCollection.
    /// </summary>
    [Serializable]
    public class StringReferenceAtomBaseVariableDictionary : SerializableDictionary<StringReference, AtomBaseVariable>, IAtomCollection
    {
        /// <summary>
        /// Generic getter.
        /// </summary>
        /// <param name="key">The key associated with the value you want to retrieve.</param>
        /// <typeparam name="T">The expected type of the value you want to retrieve.</typeparam>
        /// <returns>The value of type T if found, otherwise null.</returns>
        public T Get<T>(string key) where T : AtomBaseVariable
        {
            var enumerator = GetEnumerator();
            T toReturn = null;
            try
            {
                while (enumerator.MoveNext())
                {
                    var value = enumerator.Current.Value;
                    if (enumerator.Current.Key == key)
                    {
                        toReturn = (T)enumerator.Current.Value;
                        break;
                    }
                }
            }
            finally
            {
                enumerator.Dispose();
            }

            return toReturn;
        }

        /// <summary>
        /// Generic getter.
        /// </summary>
        /// <param name="key">The key associated with the value you want to retrieve.</param>
        /// <typeparam name="T">The expected type of the value you want to retrieve.</typeparam>
        /// <returns>The value of type T if found, otherwise null.</returns>
        public T Get<T>(AtomBaseVariable<string> key) where T : AtomBaseVariable
        {
            if (key == null) throw new ArgumentNullException("key");
            return Get<T>(key.Value);
        }

        /// <summary>
        /// Add value and its associated key to the dictionary.
        /// </summary>
        /// <param name="key">The key associated with the value.</param>
        /// <param name="value">The value to add.</param>
        public void Add(string key, AtomBaseVariable value)
        {
            var strRef = new StringReference();
            strRef.Value = key;
            base.Add(strRef, value);
        }

        /// <summary>
        /// Add value and its associated key to the dictionary.
        /// </summary>
        /// <param name="key">The key associated with the value.</param>
        /// <param name="value">The value to add.</param>
        public void Add(AtomBaseVariable<string> key, AtomBaseVariable value)
        {
            if (key == null) throw new ArgumentNullException("key");
            Add(key.Value, value);
        }

        /// <summary>
        /// Remove item by key from the collection.
        /// </summary>
        /// <param name="key">The key that you want to remove.</param>
        /// <returns>True if it removed a value from the collection, otherwise false.</returns>
        public bool Remove(string key)
        {
            var strRef = new StringReference();
            strRef.Value = key;
            return base.Remove(strRef);
        }

        /// <summary>
        /// Remove item by key from the collection.
        /// </summary>
        /// <param name="key">The key that you want to remove.</param>
        /// <returns>True if it removed a value from the collection, otherwise false.</returns>
        public bool Remove(AtomBaseVariable<string> key)
        {
            if (key == null) throw new ArgumentNullException("key");
            return Remove(key.Value);
        }
    }
}