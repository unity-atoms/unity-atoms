using System.Collections;
using System.Collections.Generic;

namespace UnityAtoms.Tags
{
    /// <summary>
    /// This is an `IList` without everything that could mutate the it.
    /// </summary>
    /// <typeparam name="T">The type of the list items.</typeparam>
    public class ReadOnlyList<T> : IEnumerable<T>
    {
        /// <summary>
        /// Get the number of elements contained in the `ReadOnlyList&lt;T&gt;`.
        /// </summary>
        /// <value>The number of elements contained in the `ReadOnlyList&lt;T&gt;`.</value>
        /// <example>
        /// <code>
        /// var readOnlyList = new ReadOnlyList&lt;int&gt;(new List&lt;int&gt;() { 1, 2, 3 });
        /// Debug.Log(readOnlyList.Count); // Outputs: 3
        /// </code>
        /// </example>
        public int Count { get => _referenceList.Count; }

        /// <summary>
        /// Determines if the `ReadOnlyList&lt;T&gt;` is read only or not.
        /// </summary>
        /// <value>Will always be `true`.</value>
        public bool IsReadOnly { get => true; }

        /// <summary>
        /// Get the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <value>The element at the specified index.</value>
        public T this[int index] { get => _referenceList[index]; }

        private readonly IList<T> _referenceList = null;

        /// <summary>
        /// Creates a new class of the `ReadOnlyList&lt;T&gt;` class.
        /// </summary>
        /// <param name="list">The `IList&lt;T&gt;` to initialize the `ReadOnlyList&lt;T&gt;` with.</param>
        public ReadOnlyList(IList<T> list)
        {
            _referenceList = list;
        }

        #region IEnumerable<T>
        /// <summary>
        /// Implements `GetEnumerator()` of `IEnumerable&lt;T&gt;`
        /// </summary>
        /// <returns>The list's `IEnumerator&lt;T&gt;`.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return _referenceList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        /// <summary>
        /// Determines whether an element is in the `ReadOnlyList&lt;T&gt;`.
        /// </summary>
        /// <param name="item">The item to check if it exists in the `ReadOnlyList&lt;T&gt;`.</param>
        /// <returns>`true` if item is found in the `ReadOnlyList&lt;T&gt;`; otherwise, `false`.</returns>
        public bool Contains(T item)
        {
            return _referenceList.Contains(item);
        }

        /// <summary>
        /// Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <param name="item">The one-dimensional array to search.</param>
        /// <returns>The index of the first occurrence of value in array, if found; otherwise, the lower bound of the array minus 1.</returns>
        public int IndexOf(T item)
        {
            return _referenceList.IndexOf(item);
        }

        /// <summary>
        /// Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 32-bit integer.
        /// </summary>
        /// <param name="array">The one-dimensional array that is the destination of the elements copied from the current array.</param>
        /// <param name="arrayIndex">A 32-bit integer that represents the index in array at which copying begins.</param>
        public void CopyTo(T[] array, int arrayIndex)
        {
            _referenceList.CopyTo(array, arrayIndex);
        }
    }
}
