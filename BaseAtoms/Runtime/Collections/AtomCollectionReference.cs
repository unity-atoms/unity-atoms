using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Different types of usages for an Atom Collection Reference.
    /// </summary>
    public class AtomCollectionReferenceUsage
    {
        public const int COLLECTION = 0;
        public const int COLLECTION_INSTANCER = 1;
    }

    /// <summary>
    /// Reference of type `AtomCollection`. Inherits from `AtomBaseReference`.
    /// </summary>
    [Serializable]
    public class AtomCollectionReference : AtomBaseReference, IGetValue<IAtomCollection>
    {
        /// <summary>
        /// Get value as an `IAtomCollection`. Needed in order to inject Collection References into the Variable Instancer class.
        /// </summary>
        /// <returns>The value as an `IAtomList`.</returns>
        public IAtomCollection GetValue() => Collection != null ? Collection.GetValue() : null;

        /// <summary>
        /// Get the value for the Reference.
        /// </summary>
        /// <value>The value of type `AtomCollection`.</value>
        public AtomCollection Collection
        {
            get
            {
                switch (_usage)
                {
                    case (AtomCollectionReferenceUsage.COLLECTION_INSTANCER):
                        return _instancer == null ? default(AtomCollection) : _instancer.Variable;
                    case (AtomCollectionReferenceUsage.COLLECTION):
                    default:
                        return _collection;
                }
            }
        }

        /// <summary>
        /// Variable used if `Usage` is set to `COLLECTION`.
        /// </summary>
        [SerializeField]
        private AtomCollection _collection = default(AtomCollection);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `COLLECTION_INSTANCER`.
        /// </summary>
        [SerializeField]
        private AtomCollectionInstancer _instancer = default(AtomCollectionInstancer);
    }
}
