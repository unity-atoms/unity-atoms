using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Generic base class for Value Lists. Inherits from `BaseAtomList` and `IList&lt;T&gt;`.
    /// </summary>
    /// <typeparam name="T">The list item type.</typeparam>
    /// <typeparam name="E">Event of type `AtomEvent&lt;T&gt;`.</typeparam>
    [EditorIcon("atom-icon-piglet")]
    public abstract class AtomValueList<T, E> : BaseAtomValueList, IList<T>
        where E : AtomEvent<T>
    {
        /// <summary>
        /// Event for when something is added to the list.
        /// </summary>
        public E Added;

        /// <summary>
        /// Event for when something is removed from the list.
        /// </summary>
        public E Removed;

        /// <summary>
        /// Get the count of the list.
        /// </summary>
        public int Count => list.Count;

        /// <summary>
        /// Is the list read only?
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Actual `List&lt;T&gt;`.
        /// </summary>
        /// <typeparam name="T">The list item type.</typeparam>
        /// <returns>The actual `List&lt;T&gt;`.</returns>
        [SerializeField]
        private List<T> list = new List<T>();

        /// <summary>
        /// Add an item to the list.
        /// </summary>
        /// <param name="item">The item to add.</param>
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

        /// <summary>
        /// Remove an item from the list.
        /// </summary>
        /// <param name="item">The item to remove.</param>
        /// <returns>True if it was removed, otherwise false..</returns>
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

        /// <summary>
        /// Does the list contain the item provided?
        /// </summary>
        /// <param name="item">The item to check if it is contained in the list.</param>
        /// <returns>`true` if the item exists in the list, otherwise `false`.</returns>
        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        /// <summary>
        /// Get item at index.
        /// </summary>
        /// <param name="i">The index.</param>
        /// <returns>The item if it exists.</returns>
        public T Get(int i)
        {
            return list[i];
        }

        /// <summary>
        /// The actual `List&lt;T&gt;` as a property.
        /// </summary>
        /// <value>Get or set the value of the list.</value>
        public List<T> List
        {
            get { return list; }
            set { list = value; }
        }

        /// <summary>
        /// Indexer of the list.
        /// </summary>
        /// <value>Get or set an item via index in the list.</value>
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

        /// <summary>
        /// Copies the entire List to a compatible one-dimensional array, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements copied from List. The Array must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in `array` at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();

        /// <summary>
        /// Get an `IEnumerator&lt;T&gt;` of the list.
        /// </summary>
        /// <returns>An `IEnumerator&lt;T&gt;`</returns>
        public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

        /// <summary>
        /// Returns the index of the specified item.
        /// </summary>
        /// <param name="item">The item to search for.</param>
        /// <returns>The zero-based index of the first occurrence of `item`. If not found it returns -1.</returns>
        public int IndexOf(T item) => list.IndexOf(item);

        /// <summary>
        /// Remove an item at provided index.
        /// </summary>
        /// <param name="index">The index to remove item at.</param>
        public void RemoveAt(int index)
        {
            var item = list[index];
            list.RemoveAt(index);
            if (null != Removed)
            {
                Removed.Raise(item);
            }
        }

        /// <summary>
        /// Insert item at index.
        /// </summary>
        /// <param name="index">Index to insert item at.</param>
        /// <param name="item">Item to insert.</param>
        public void Insert(int index, T item)
        {
            list.Insert(index, item);
            if (Added != null)
            {
                Added.Raise(item);
            }
        }

        #region Observable
        /// <summary>
        /// Make the add event into an `IObservable&lt;T&gt;`. Makes Value List's add Event compatible with for example UniRx.
        /// </summary>
        /// <returns>The add Event as an `IObservable&lt;T&gt;`.</returns>
        public IObservable<T> ObserveAdd()
        {
            if (Added == null)
            {
                throw new Exception("You must assign an Added event in order to observe when adding to the value list.");
            }

            return new ObservableEvent<T>(Added.Register, Added.Unregister);
        }

        /// <summary>
        /// Make the remove event into an `IObservable&lt;T&gt;`. Makes Value List's remove Event compatible with for example UniRx.
        /// </summary>
        /// <returns>The remove Event as an `IObservable&lt;T&gt;`.</returns>
        public IObservable<T> ObserveRemove()
        {
            if (Removed == null)
            {
                throw new Exception("You must assign a Removed event in order to observe when removing from the value list.");
            }

            return new ObservableEvent<T>(Removed.Register, Removed.Unregister);
        }

        /// <summary>
        /// Make the clear event into an `IObservable&lt;Void&gt;`. Makes Value List's clear Event compatible with for example UniRx.
        /// </summary>
        /// <returns>The clear Event as an `IObservable&lt;Void&gt;`.</returns>
        public IObservable<Void> ObserveClear()
        {
            if (Cleared == null)
            {
                throw new Exception("You must assign a Cleared event in order to observe when clearing the value list.");
            }

            return new ObservableVoidEvent(Cleared.Register, Cleared.Unregister);
        }

        #endregion // Observable

        protected override IList IList { get => List; }
    }
}
