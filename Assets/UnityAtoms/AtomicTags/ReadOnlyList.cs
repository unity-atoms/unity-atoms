using System;
using System.Collections;
 using System.Collections.Generic;
 
 namespace UnityAtoms {
     /// <summary>
     /// This is basically an IList without everything that could mutate the list
     /// </summary>
     public class ReadOnlyList<T> : IEnumerable, IEnumerable<T> {
         private readonly IList<T> referenceList;
 
         public ReadOnlyList(IList<T> referenceList) { this.referenceList = referenceList; }
 
         public IEnumerator<T> GetEnumerator() { return referenceList.GetEnumerator(); }
 
         IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
 
         public bool Contains(T item) { return referenceList.Contains(item); }
         public int IndexOf(T item) { return referenceList.IndexOf(item); }
         
         public void CopyTo(T[] array, int arrayIndex) { referenceList.CopyTo(array, arrayIndex); }
         
         public int Count {
             get { return referenceList.Count; }
         }

         public bool IsReadOnly {
             get { return true; }
         }

         public T this[int index] {
             get { return referenceList[index]; }
         }
     }

 }