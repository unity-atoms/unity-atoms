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

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    public abstract class AtomAction<T1, T2> : AtomAction
    {
        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        public virtual void Do(T1 t1, T2 t2) => base.Do();
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    /// <typeparam name="T3">The third type for this Action.</typeparam>
    public abstract class AtomAction<T1, T2, T3> : AtomAction
    {
        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        public virtual void Do(T1 t1, T2 t2, T3 t3) => base.Do();
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    /// <typeparam name="T3">The third type for this Action.</typeparam>
    /// <typeparam name="T4">The fourth type for this Action.</typeparam>
    public abstract class AtomAction<T1, T2, T3, T4> : AtomAction
    {
        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4) => base.Do();
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `AtomAction`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    /// <typeparam name="T3">The third type for this Action.</typeparam>
    /// <typeparam name="T4">The fourth type for this Action.</typeparam>
    /// <typeparam name="T5">The fifth type for this Action.</typeparam>
    public abstract class AtomAction<T1, T2, T3, T4, T5> : AtomAction
    {
        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        /// <param name="t5">The fifth parameter.</param>
        public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5) => base.Do();
    }
}
