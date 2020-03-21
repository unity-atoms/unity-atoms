using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Base abstract class for Actions. Inherits from `BaseAtom`.
    /// </summary>
    public abstract class AtomAction : BaseAtom
    {
        /// <summary>
        /// Perform the Action.
        /// </summary>
        public virtual void Do() { }
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T1">The type for this Action.</typeparam>
    public abstract class AtomAction<T1> : AtomAction
    {
        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        public virtual void Do(T1 t1) => base.Do();
    }
}
