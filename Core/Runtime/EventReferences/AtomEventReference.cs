using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// An Event Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event, Event Instancer, Variable or a Variable Instancer.
    /// </summary>
    /// <typeparam name="T">The type of the event.</typeparam>
    /// <typeparam name="V">Variable of type `T`.</typeparam>
    /// <typeparam name="E">Event of type `T`.</typeparam>
    /// <typeparam name="VI">Variable Instancer of type `T`.</typeparam>
    /// <typeparam name="EI">Event Instancer of type `T`.</typeparam>
    public abstract class AtomEventReference<T, V, E, VI, EI> : AtomEventReferenceBase, IGetEvent, ISetEvent
        where V : IGetEvent, ISetEvent
        where E : AtomEvent<T>
        where VI : IGetEvent, ISetEvent
        where EI : AtomEventInstancer<T, E>
    {
        /// <summary>
        /// Get the event for the Event Reference.
        /// </summary>
        /// <value>The event of type `E`.</value>
        public E Event
        {
            get
            {
                switch (_usage)
                {
                    case (AtomEventReferenceBase.Usage.Variable): return _variable.GetEvent<E>();
                    case (AtomEventReferenceBase.Usage.VariableInstancer): return _variableInstancer.GetEvent<E>();
                    case (AtomEventReferenceBase.Usage.EventInstancer): return _eventInstancer.Event;
                    case (AtomEventReferenceBase.Usage.Event):
                    default:
                        return _event;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomEventReferenceBase.Usage.Variable):
                        {
                            _variable.SetEvent<E>(value);
                            break;
                        }
                    case (AtomEventReferenceBase.Usage.VariableInstancer):
                        {
                            _variableInstancer.SetEvent<E>(value);
                            break;
                        }
                    case (AtomEventReferenceBase.Usage.Event):
                        {
                            _event = value;
                            break;
                        }
                    default:
                        throw new NotSupportedException($"Event not reassignable for usage {_usage}.");
                }
            }
        }

        /// <summary>
        /// Event used if `Usage` is set to `Event`.
        /// </summary>
        [SerializeField]
        private E _event = default(E);

        /// <summary>
        /// EventInstancer used if `Usage` is set to `EventInstancer`.
        /// </summary>
        [SerializeField]
        private EI _eventInstancer = default(EI);

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        [SerializeField]
        private V _variable = default(V);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `VariableInstancer`.
        /// </summary>
        [SerializeField]
        private VI _variableInstancer = default(VI);

        protected AtomEventReference()
        {
            _usage = AtomEventReferenceBase.Usage.Event;
        }

        public static implicit operator E(AtomEventReference<T, V, E, VI, EI> reference)
        {
            return reference.Event;
        }

        /// <summary>
        /// Get event by type. Don't use directly! Used only so that we don't need two implementations of Event Instancer and Listeners (one for `T` and one for `IPair&lt;T&gt;`)
        /// </summary>
        /// <typeparam name="E"></typeparam>
        /// <returns>The event.</returns>
        public EO GetEvent<EO>() where EO : AtomEventBase
        {
            if (typeof(EO) == typeof(E))
                return (Event as EO);

            throw new Exception($"Event type {typeof(EO)} not supported! Use {typeof(E)}.");
        }

        /// <summary>
        /// Set event by type. Don't use directly! Used only so that we don't need two implementations of Event Instancer and Listeners (one for `T` and one for `IPair&lt;T&gt;`)
        /// </summary>
        /// <param name="e">The new event value.</param>
        /// <typeparam name="E"></typeparam>
        public void SetEvent<EO>(EO e) where EO : AtomEventBase
        {
            if (typeof(EO) == typeof(E))
            {
                Event = (e as E);
                return;
            }

            throw new Exception($"Event type {typeof(EO)} not supported! Use {typeof(E)}.");
        }
    }
}
