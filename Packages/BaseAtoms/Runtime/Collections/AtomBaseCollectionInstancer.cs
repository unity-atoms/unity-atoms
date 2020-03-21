using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Creates an in memory copy of a Collection using a base.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="V"></typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomBaseCollectionInstancer<T, V> : AtomBaseVariableInstancer<T, V>
        where V : AtomBaseVariable<T>, IWithCollectionEvents
    {
        /// <summary>
        /// Creates in memory copies of the Added, Removed and Cleared Events on OnEnable.
        /// </summary>
        protected override void ImplSpecificSetup()
        {
            var baseCollection = (V)Base;
            var inMemoryCopy = (V)_inMemoryCopy;

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
