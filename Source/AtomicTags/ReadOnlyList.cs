using System.Collections;
using System.Collections.Generic;

namespace UnityAtoms.Tags
{
    /// <summary>
    /// This is basically an IList without everything that could mutate the list
    /// </summary>
    public class ReadOnlyList<T> : IEnumerable<T>
    {
        private readonly IList<T> _referenceList = null;

        public ReadOnlyList(IList<T> referenceList)
        {
            _referenceList = referenceList;
        }

        #region IEnumerable<T>

        public IEnumerator<T> GetEnumerator()
        {
            return _referenceList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        public bool Contains(T item)
        {
            return _referenceList.Contains(item);
        }

        public int IndexOf(T item)
        {
            return _referenceList.IndexOf(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _referenceList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return _referenceList.Count; }
        }

        public bool IsReadOnly
        {
            get { return true; }
        }

        public T this[int index]
        {
            get { return _referenceList[index]; }
        }
    }
}
