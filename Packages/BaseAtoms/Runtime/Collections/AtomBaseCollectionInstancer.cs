using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Creates an in memory copy of a Collection using a base.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomBaseCollectionInstancer<T> : AtomVariableInstancer<T>
    {
        public AtomBaseVariableEvent Added
        {
            get => ((IWithCollectionEvents)_inMemoryCopy).Added;
            set => ((IWithCollectionEvents)_inMemoryCopy).Added = value;
        }

        public AtomBaseVariableEvent Removed
        {
            get => ((IWithCollectionEvents)_inMemoryCopy).Removed;
            set => ((IWithCollectionEvents)_inMemoryCopy).Removed = value;
        }

        public VoidEvent Cleared
        {
            get => ((IWithCollectionEvents)_inMemoryCopy).Cleared;
            set => ((IWithCollectionEvents)_inMemoryCopy).Cleared = value;
        }

        /// <summary>
        /// Creates in memory copies of the Added, Removed and Cleared Events on OnEnable.
        /// </summary>
        protected override void ImplSpecificSetup()
        {
            var baseCollection = (IWithCollectionEvents)Base;
            var inMemoryCopy = (IWithCollectionEvents)_inMemoryCopy;

            if (baseCollection.Added != null)
            {
                inMemoryCopy.Added = Instantiate(baseCollection.Added);
            }

            if (baseCollection.Removed != null)
            {
                inMemoryCopy.Removed = Instantiate(baseCollection.Removed);
            }

            if (baseCollection.Cleared != null)
            {
                inMemoryCopy.Cleared = Instantiate(baseCollection.Cleared);
            }
        }
    }
}
