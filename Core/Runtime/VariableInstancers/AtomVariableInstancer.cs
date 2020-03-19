using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace UnityAtoms
{
    /// <summary>
    /// A Variable Instancer is a MonoBehaviour that takes a variable as a base and creates an in memory copy of it OnEnable.
    /// This is handy when you want to use atoms for prefabs that are instantiated at runtime. Use together with AtomCollection to
    /// react accordingly when a prefab with an associated atom is added or deleted to the scene.
    /// </summary>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="P">IPair of type `T`.</typeparam>
    /// <typeparam name="T">The value type.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T</typeparam>
    [EditorIcon("atom-icon-hotpink")]
    [DefaultExecutionOrder(Runtime.ExecutionOrder.VARIABLE_INSTANCER)]
    public abstract class AtomVariableInstancer<V, P, T, E1, E2, F> : AtomBaseVariableInstancer<T, V>, IGetEvent, ISetEvent
        where V : AtomVariable<T, P, E1, E2, F>
        where P : struct, IPair<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
    {
        /// <summary>
        /// Override to add implementation specific setup on `OnEnable`.
        /// </summary>
        protected override void ImplSpecificSetup()
        {
            if (Base.Changed != null)
            {
                _inMemoryCopy.Changed = Instantiate(Base.Changed);
            }

            if (Base.ChangedWithHistory != null)
            {
                _inMemoryCopy.ChangedWithHistory = Instantiate(Base.ChangedWithHistory);
            }
        }

        /// <summary>
        /// Get event by type. 
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>The event.</returns>
        public E GetEvent<E>() where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
                return (_inMemoryCopy.Changed as E);
            if (typeof(E) == typeof(E2))
                return (_inMemoryCopy.ChangedWithHistory as E);

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }

        /// <summary>
        /// Set event by type. 
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<E>(E e) where E : AtomEventBase
        {
            if (typeof(E) == typeof(E1))
            {
                _inMemoryCopy.Changed = (e as E1);
                return;
            }
            if (typeof(E) == typeof(E2))
            {
                _inMemoryCopy.ChangedWithHistory = (e as E2);
                return;
            }

            throw new Exception($"Event type {typeof(E)} not supported! Use {typeof(E1)} or {typeof(E2)}.");
        }
    }
}
