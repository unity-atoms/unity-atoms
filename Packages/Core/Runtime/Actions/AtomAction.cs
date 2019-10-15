using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="T1">The type for this Action.</typeparam>
    [EditorIcon("atom-icon-purple")]
    public abstract class AtomAction<T1> : BaseAtom
    {
        /// <summary>
        /// The actual Action.
        /// </summary>
        [HideInInspector]
        public Action<T1> Action;

        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        public virtual void Do(T1 t1)
        {
            if (Action != null)
            {
                Action(t1);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    [EditorIcon("atom-icon-purple")]
    public abstract class AtomAction<T1, T2> : BaseAtom
    {
        /// <summary>
        /// The actual Action.
        /// </summary>
        [HideInInspector]
        public Action<T1, T2> Action;

        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        public virtual void Do(T1 t1, T2 t2)
        {
            if (Action != null)
            {
                Action(t1, t2);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    /// <typeparam name="T3">The third type for this Action.</typeparam>
    [EditorIcon("atom-icon-purple")]
    public abstract class AtomAction<T1, T2, T3> : BaseAtom
    {
        /// <summary>
        /// The actual Action.
        /// </summary>
        [HideInInspector]
        public Action<T1, T2, T3> Action;

        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        public virtual void Do(T1 t1, T2 t2, T3 t3)
        {
            if (Action != null)
            {
                Action(t1, t2, t3);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    /// <typeparam name="T3">The third type for this Action.</typeparam>
    /// <typeparam name="T4">The fourth type for this Action.</typeparam>
    [EditorIcon("atom-icon-purple")]
    public abstract class AtomAction<T1, T2, T3, T4> : BaseAtom
    {
        /// <summary>
        /// The actual Action.
        /// </summary>
        [HideInInspector]
        public Action<T1, T2, T3, T4> Action;

        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Action != null)
            {
                Action(t1, t2, t3, t4);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }

    /// <summary>
    /// Generic abstract base class for Actions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="T1">The first type for this Action.</typeparam>
    /// <typeparam name="T2">The second type for this Action.</typeparam>
    /// <typeparam name="T3">The third type for this Action.</typeparam>
    /// <typeparam name="T4">The fourth type for this Action.</typeparam>
    /// <typeparam name="T5">The fifth type for this Action.</typeparam>
    [EditorIcon("atom-icon-purple")]
    public abstract class AtomAction<T1, T2, T3, T4, T5> : BaseAtom
    {
        /// <summary>
        /// The actual Action.
        /// </summary>
        [HideInInspector]
        public Action<T1, T2, T3, T4, T5> Action;

        /// <summary>
        /// Perform the Action.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        /// <param name="t5">The fifth parameter.</param>
        public virtual void Do(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (Action != null)
            {
                Action(t1, t2, t3, t4, t5);
                return;
            }

            throw new Exception("Either set Action or override the Do method.");
        }
    }
}
