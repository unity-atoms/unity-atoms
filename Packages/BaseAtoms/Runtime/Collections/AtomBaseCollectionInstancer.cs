using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomBaseCollectionInstancer<T, V> : AtomBaseVariableInstancer<T, V>
        where V : AtomBaseVariable<T>, IWithCollectionEvents
    {
        /// <summary>
        /// Override to add implementation specific setup on `OnEnable`.
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
