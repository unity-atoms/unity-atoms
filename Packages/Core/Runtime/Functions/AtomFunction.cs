using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R> : BaseAtom
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        public Func<R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call()
        {
            if (Func == null)
                throw new InvalidOperationException("Either set Func or override the Call method.");

            return Func();
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;R&gt;` to set.</param>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>An `AtomFunction&lt;R&gt;`.</returns>
        public AtomFunction<R> SetFunc(Func<R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The parameter type for this Function.</typeparam>
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1> : BaseAtom
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        public Func<T1, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1)
        {
            if (Func == null)
                throw new InvalidOperationException("Either set Func or override the Call method.");

            return Func(t1);
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1&gt;`.</returns>
        public AtomFunction<R, T1> SetFunc(Func<T1, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2> : BaseAtom
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        public Func<T1, T2, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2)
        {
            if (Func == null)
                throw new InvalidOperationException("Either set Func or override the Call method.");

            return Func(t1, t2);
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2&gt;`.</returns>
        public AtomFunction<R, T1, T2> SetFunc(Func<T1, T2, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    /// <typeparam name="T3">The third parameter type for this Function.</typeparam>
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2, T3> : BaseAtom
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        public Func<T1, T2, T3, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2, T3 t3)
        {
            if (Func == null)
                throw new InvalidOperationException("Either set Func or override the Call method.");

            return Func(t1, t2, t3);
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, T3, R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, T3, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2, T3&gt;`.</returns>
        public AtomFunction<R, T1, T2, T3> SetFunc(Func<T1, T2, T3, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    /// <typeparam name="T3">The third parameter type for this Function.</typeparam>
    /// <typeparam name="T4">The fourth parameter type for this Function.</typeparam>
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2, T3, T4> : BaseAtom
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        public Func<T1, T2, T3, T4, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Func == null)
                throw new InvalidOperationException("Either set Func or override the Call method.");

            return Func(t1, t2, t3, t4);
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, T3, T4 R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, T3, T4, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2, T3, T4&gt;`.</returns>
        public AtomFunction<R, T1, T2, T3, T4> SetFunc(Func<T1, T2, T3, T4, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    /// <typeparam name="T3">The third parameter type for this Function.</typeparam>
    /// <typeparam name="T4">The fourth parameter type for this Function.</typeparam>
    /// <typeparam name="T5">The fifth parameter type for this Function.</typeparam>
    [EditorIcon("atom-icon-sand")]
    public abstract class AtomFunction<R, T1, T2, T3, T4, T5> : BaseAtom
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        public Func<T1, T2, T3, T4, T5, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        /// <param name="t5">The fifth parameter.</param>
        /// <exception cref="InvalidOperationException">If <see cref="Func"/> is not set.</exception>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (Func == null)
                throw new InvalidOperationException("Either set Func or override the Call method.");

            return Func(t1, t2, t3, t4, t5);
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, T3, T4, T5 R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, T3, T4, T5, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2, T3, T4, T5&gt;`.</returns>
        public AtomFunction<R, T1, T2, T3, T4, T5> SetFunc(Func<T1, T2, T3, T4, T5, R> func)
        {
            Func = func;
            return this;
        }
    }
}
