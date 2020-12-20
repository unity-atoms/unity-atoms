using System.Collections;

namespace UnityAtoms
{
    /// <summary>
    /// None generic base class of Lists.Inherits from `BaseAtom`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    public abstract class BaseAtomList : BaseAtom
    {
        /// <summary>
        /// Event for when the list is cleared.
        /// </summary>
        public VoidEvent Cleared;
        protected abstract IList IList { get; }

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
    }
}
