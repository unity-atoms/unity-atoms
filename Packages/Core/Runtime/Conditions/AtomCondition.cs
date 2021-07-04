using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Base abstract class for Conditions. Inherits from `BaseAtom`.
    /// </summary>
    public abstract class AtomCondition : BaseAtom
    {
        /// <summary>
        /// Check the condition.
        /// </summary>
        public virtual bool Call() => false;
    }

    /// <summary>
    /// Generic abstract base class for Conditions. Inherits from `AtomCondition`.
    /// </summary>
    public abstract class AtomCondition<T> : AtomCondition
    {
        /// <summary>
        /// Evaluate the Condition.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        public virtual bool Call(T t) => base.Call();
    }
}
