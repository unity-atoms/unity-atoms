using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Different types of usages for an Atom List Reference.
    /// </summary>
    public class AtomListReferenceUsage
    {
        public const int LIST = 0;
        public const int LIST_INSTANCER = 1;
    }

    /// <summary>
    /// Reference of type `AtomList`. Inherits from `AtomBaseReference`.
    /// </summary>
    [Serializable]
    public class AtomListReference : AtomBaseReference, IGetValue<IAtomList>
    {
        /// <summary>
        /// Get value as an `IAtomList`. Needed in order to inject List References into the Variable Instancer class.
        /// </summary>
        /// <returns>The value as an `IAtomList`.</returns>
        public IAtomList GetValue() => List != null ? List.GetValue() : null;

        /// <summary>
        /// Get the value for the Reference.
        /// </summary>
        /// <value>The value of type `AtomList`.</value>
        public AtomList List
        {
            get
            {
                switch (_usage)
                {
                    case (AtomListReferenceUsage.LIST_INSTANCER):
                        return _instancer == null ? default(AtomList) : _instancer.Variable;
                    case (AtomListReferenceUsage.LIST):
                    default:
                        return _list;
                }
            }
        }

        /// <summary>
        /// Variable used if `Usage` is set to `LIST`.
        /// </summary>
        [SerializeField]
        private AtomList _list = default(AtomList);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `LIST_INSTANCER`.
        /// </summary>
        [SerializeField]
        private AtomListInstancer _instancer = default(AtomListInstancer);
    }
}
