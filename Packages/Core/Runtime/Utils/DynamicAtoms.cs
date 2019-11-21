using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Static helper class for when creating Atoms a runtime (yes it is indeed possible 🤯).
    /// </summary>
    public static class DynamicAtoms
    {
        /// <summary>
        /// Create a Variable at runtime.
        /// </summary>
        /// <param name="initialValue">Inital value of the Variable created.</param>
        /// <param name="changed">Changed Event of type `E1`.</param>
        /// <param name="changedWithHistory">Changed with history Event of type `E2`.</param>
        /// <param name="preChangeTransformers">List of pre change transformers of the type `List&lt;F&gt;`.</param>
        /// <typeparam name="T">The Variable value type.</typeparam>
        /// <typeparam name="V">The Variable type AtomVariable&lt;T, E1, E2&gt;`.</typeparam>
        /// <typeparam name="E1">The type of the `changed` Event of type `AtomEvent&lt;T&gt;`.</typeparam>
        /// <typeparam name="E2">The type of the `changedWithHistory` Event of type `AtomEvent&lt;T, T&gt;`.</typeparam>
        /// <typeparam name="F">The type of the `preChangeTransformers` Functions of type `AtomFunction&lt;T, T&gt;`.</typeparam>
        /// <returns>The Variable created.</returns>
        public static V CreateVariable<T, V, E1, E2, F>(T initialValue, E1 changed = null, E2 changedWithHistory = null, List<F> preChangeTransformers = null)
            where V : AtomVariable<T, E1, E2, F>
            where E1 : AtomEvent<T> where E2 : AtomEvent<T, T>
            where F : AtomFunction<T, T>
        {
            var sov = ScriptableObject.CreateInstance<V>();
            sov.Changed = changed;
            sov.ChangedWithHistory = changedWithHistory;
            sov.Value = initialValue;
            sov.PreChangeTransformers = preChangeTransformers;
            return sov;
        }

        /// <summary>
        /// Create a List at runtime.
        /// </summary>
        /// <param name="added">Added Event of type `E`.</param>
        /// <param name="removed">Removed Event of type `E`.</param>
        /// <param name="cleared">Cleared Event of type `Void`.</param>
        /// <typeparam name="T">The list item type.</typeparam>
        /// <typeparam name="L">The List type to create of type `AtomList&lt;T, E&gt;`.</typeparam>
        /// <typeparam name="E">The Event tyoe used for `removed` and `added` of type `AtomEvent&lt;T&gt;`.</typeparam>
        /// <returns>The List created.</returns>
        public static L CreateList<T, L, E>(E added = null, E removed = null, VoidEvent cleared = null)
            where L : AtomList<T, E>
            where E : AtomEvent<T>
        {
            var sol = ScriptableObject.CreateInstance<L>();
            sol.Added = added;
            sol.Removed = removed;
            sol.Cleared = cleared;
            return sol;
        }

        /// <summary>
        /// Create an Action at runtime.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <typeparam name="A">The Action created of type `AtomAction&lt;T&gt;`.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Action.</typeparam>
        /// <returns>The Action created</returns>
        public static A CreateAction<A, T1>(Action<T1> action)
            where A : AtomAction<T1>
        {
            var ga = ScriptableObject.CreateInstance<A>();
            ga.Action = action;
            return ga;
        }

        /// <summary>
        /// Create an Action at runtime.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <typeparam name="A">The Action created of type `AtomAction&lt;T1, T2&gt;`.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Action.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Action.</typeparam>
        /// <returns>The Action created</returns>
        public static A CreateAction<A, T1, T2>(Action<T1, T2> action)
            where A : AtomAction<T1, T2>
        {
            var ga = ScriptableObject.CreateInstance<A>();
            ga.Action = action;
            return ga;
        }

        /// <summary>
        /// Create an Action at runtime.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <typeparam name="A">The Action created of type `AtomAction&lt;T1, T2, T3&gt;`.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Action.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Action.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the Action.</typeparam>
        /// <returns>The Action created</returns>
        public static GA CreateAction<GA, T1, T2, T3>(Action<T1, T2, T3> action)
            where GA : AtomAction<T1, T2, T3>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        /// <summary>
        /// Create an Action at runtime.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <typeparam name="A">The Action created of type `AtomAction&lt;T1, T2, T3, T4&gt;`.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Action.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Action.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the Action.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the Action.</typeparam>
        /// <returns>The Action created</returns>
        public static GA CreateAction<GA, T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
            where GA : AtomAction<T1, T2, T3, T4>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        /// <summary>
        /// Create an Action at runtime.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <typeparam name="A">The Action created of type `AtomAction&lt;T1, T2, T3, T4, T5&gt;`.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Action.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Action.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the Action.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the Action.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the Action.</typeparam>
        /// <returns>The Action created</returns>
        public static GA CreateAction<GA, T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
            where GA : AtomAction<T1, T2, T3, T4, T5>
        {
            var ga = ScriptableObject.CreateInstance<GA>();
            ga.Action = action;
            return ga;
        }

        /// <summary>
        /// Create a Function at runtime.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <typeparam name="F">The Function created of type `AtomFunction&lt;R&gt;`.</typeparam>
        /// <typeparam name="R">The return type.</typeparam>
        /// <returns>The Function crated.</returns>
        public static F CreateFunction<F, R>(Func<R> func)
            where F : AtomFunction<R>
        {
            var gf = ScriptableObject.CreateInstance<F>();
            gf.Func = func;
            return gf;
        }

        /// <summary>
        /// Create a Function at runtime.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <typeparam name="F">The Function created of type `AtomFunction&lt;R, T1&gt;`.</typeparam>
        /// <typeparam name="R">The return type.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Function.</typeparam>
        /// <returns>The Function crated.</returns>
        public static F CreateFunction<F, R, T1>(Func<T1, R> func)
            where F : AtomFunction<R, T1>
        {
            var gf = ScriptableObject.CreateInstance<F>();
            gf.Func = func;
            return gf;
        }

        /// <summary>
        /// Create a Function at runtime.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <typeparam name="F">The Function created of type `AtomFunction&lt;R, T1, T2&gt;`.</typeparam>
        /// <typeparam name="R">The return type.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Function.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Function.</typeparam>
        /// <returns>The Function crated.</returns>
        public static F CreateFunction<F, R, T1, T2>(Func<T1, T2, R> func)
            where F : AtomFunction<R, T1, T2>
        {
            var gf = ScriptableObject.CreateInstance<F>();
            gf.Func = func;
            return gf;
        }

        /// <summary>
        /// Create a Function at runtime.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <typeparam name="F">The Function created of type `AtomFunction&lt;R, T1, T2, T3&gt;`.</typeparam>
        /// <typeparam name="R">The return type.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Function.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Function.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the Function.</typeparam>
        /// <returns>The Function crated.</returns>
        public static F CreateFunction<F, R, T1, T2, T3>(Func<T1, T2, T3, R> func)
            where F : AtomFunction<R, T1, T2, T3>
        {
            var gf = ScriptableObject.CreateInstance<F>();
            gf.Func = func;
            return gf;
        }

        /// <summary>
        /// Create a Function at runtime.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <typeparam name="F">The Function created of type `AtomFunction&lt;R, T1, T2, T3, T4&gt;`.</typeparam>
        /// <typeparam name="R">The return type.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Function.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Function.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the Function.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the Function.</typeparam>
        /// <returns>The Function crated.</returns>
        public static F CreateFunction<F, R, T1, T2, T3, T4>(Func<T1, T2, T3, T4, R> func)
            where F : AtomFunction<R, T1, T2, T3, T4>
        {
            var gf = ScriptableObject.CreateInstance<F>();
            gf.Func = func;
            return gf;
        }

        /// <summary>
        /// Create a Function at runtime.
        /// </summary>
        /// <param name="func">The function.</param>
        /// <typeparam name="F">The Function created of type `AtomFunction&lt;R, T1, T2, T3, T4, T5&gt;`.</typeparam>
        /// <typeparam name="R">The return type.</typeparam>
        /// <typeparam name="T1">The type of the first parameter of the Function.</typeparam>
        /// <typeparam name="T2">The type of the second parameter of the Function.</typeparam>
        /// <typeparam name="T3">The type of the third parameter of the Function.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter of the Function.</typeparam>
        /// <typeparam name="T5">The type of the fifth parameter of the Function.</typeparam>
        /// <returns>The Function crated.</returns>
        public static F CreateFunction<F, R, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, R> func)
            where F : AtomFunction<R, T1, T2, T3, T4, T5>
        {
            var gf = ScriptableObject.CreateInstance<F>();
            gf.Func = func;
            return gf;
        }
    }
}
