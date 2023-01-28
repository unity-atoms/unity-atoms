using System.Collections;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class of Lists. Inherits from `BaseAtom`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    public abstract class BaseAtomValueList : BaseAtom
    {
        /// <summary>
        /// Event for when the list is cleared.
        /// </summary>
        public AtomEventBase Cleared;
        protected abstract IList IList { get; }

        /// <summary>
        /// Whether the list should start cleared
        /// </summary>
        [SerializeField]
        protected bool _startCleared;

        /// <summary>
        /// Clear the list.
        /// </summary>
        public void Clear()
        {
            IList.Clear();
            if (null != Cleared)
            {
                Cleared.Raise();
            }
        }
        private void OnEnable()
        {
            if (_startCleared)
            {
                Clear();
            }
        }
    }
}
