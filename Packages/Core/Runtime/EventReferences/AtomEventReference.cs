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
    public abstract class AtomEventReference<T, V, E, VI, EI>
        : AtomBaseEventReference<T, E, EI>, IGetEvent, ISetEvent, ITryGetOrCreateEvent, ITryGetEvent
        where V : IGetOrCreateEvent, ITryGetEvent, ISetEvent
        where E : AtomEvent<T>
        where VI : IGetOrCreateEvent, ITryGetEvent, ISetEvent
        where EI : AtomEventInstancer<T, E>
    {
        /// <summary>
        /// Get or set the Event used by the Event Reference.
        /// </summary>
        /// <value>The event of type `E`.</value>
        public override E Event
        {
            get
            {
                switch (_usage)
                {
                    case (AtomEventReferenceUsage.VARIABLE): return _variable == null ? null : _variable.GetOrCreateEvent<E>();
                    case (AtomEventReferenceUsage.VARIABLE_INSTANCER): return _variableInstancer == null ? null : _variableInstancer.GetOrCreateEvent<E>();
                    case (AtomEventReferenceUsage.EVENT_INSTANCER): return _eventInstancer == null ? null : _eventInstancer.Event;
                    case (AtomEventReferenceUsage.EVENT):
                    default:
                        return _event;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomEventReferenceUsage.VARIABLE):
                        {
                            _variable.SetEvent<E>(value);
                            break;
                        }
                    case (AtomEventReferenceUsage.VARIABLE_INSTANCER):
                        {
                            _variableInstancer.SetEvent<E>(value);
                            break;
                        }
                    case (AtomEventReferenceUsage.EVENT):
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
            _usage = AtomEventReferenceUsage.EVENT;
        }

        public static implicit operator E(AtomEventReference<T, V, E, VI, EI> reference)
        {
            return reference.Event;
        }

        public bool TryGetOrCreateEvent<E1>(out E1 atomEvent) where E1 : AtomEventBase
        {
            ITryGetOrCreateEvent bakingField = null;
            switch (_usage)
            {
                case (AtomEventReferenceUsage.VARIABLE): bakingField = _variable; break;
                case (AtomEventReferenceUsage.VARIABLE_INSTANCER): bakingField = _variableInstancer; break;
                case (AtomEventReferenceUsage.EVENT_INSTANCER): bakingField = _eventInstancer; break;
                case (AtomEventReferenceUsage.EVENT): bakingField = _event; break;
                default: bakingField = null; break;
            }
            if (bakingField != null)
            {
                var result = bakingField.TryGetOrCreateEvent<E1>(out atomEvent);
                return result;
            }
            else
            {
                atomEvent = null;
                return false;
            }
        }

        public bool TryGetEvent<E1>(out E1 atomEvent) where E1 : AtomEventBase
        {
            ITryGetEvent bakingField = null;
            switch (_usage)
            {
                case (AtomEventReferenceUsage.VARIABLE): bakingField = _variable; break;
                case (AtomEventReferenceUsage.VARIABLE_INSTANCER): bakingField = _variableInstancer; break;
                case (AtomEventReferenceUsage.EVENT_INSTANCER): bakingField = _eventInstancer; break;
                case (AtomEventReferenceUsage.EVENT): bakingField = _event; break;
                default: bakingField = null; break;
            }
            if (bakingField != null)
            {
                var result = bakingField.TryGetEvent<E1>(out atomEvent);
                return result;
            }
            else
            {
                atomEvent = null;
                return false;
            }
        }
    }
}
