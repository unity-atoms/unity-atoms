using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Needed in order to create a property drawer for a List / Array. See this for more info: https://answers.unity.com/questions/605875/custompropertydrawer-for-array-types-in-43.html
    /// </summary>
    /// <typeparam name="T">Type used in list.</typeparam>
    public abstract class AtomListWrapper<T>
    {
        public List<T> List { get => _list; }

        [SerializeField]
        private List<T> _list = default;
    }
}