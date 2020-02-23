using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// An Event x 2 Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event x 2, Variable or a Variable Instancer.
    /// </summary>
    /// <typeparam name="T">The type of the event.</typeparam>
    /// <typeparam name="V">Variable of type T.</typeparam>
    /// <typeparam name="E1">Event of type T.</typeparam>
    /// <typeparam name="E2">Event x 2 of type T.</typeparam>
    /// <typeparam name="F">Function of type T => T.</typeparam>
    /// <typeparam name="VI">Variable Instancer of type T.</typeparam>
    public abstract class AtomEventX2Reference<T, V, E1, E2, F, VI> : AtomEventReferenceBase
        where V : AtomVariable<T, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<T, T>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, T, E1, E2, F>
    {
        /// <summary>
        /// Get or set the event for the Event Reference.
        /// </summary>
        /// <value>The event of type `E2`.</value>
        public E2 Event
        {
            get
            {
                switch (_usage)
                {
                    case (AtomEventReferenceBase.Usage.Variable): return _variable.ChangedWithHistory;
                    case (AtomEventReferenceBase.Usage.VariableInstancer): return _variableInstancer.Variable.ChangedWithHistory;
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
                            _variable.ChangedWithHistory = value;
                            break;
                        }
                    case (AtomEventReferenceBase.Usage.VariableInstancer):
                        {
                            _variableInstancer.Variable.ChangedWithHistory = value;
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
        private E2 _event;

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        [SerializeField]
        private V _variable;

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `VariableInstancer`.
        /// </summary>
        [SerializeField]
        private VI _variableInstancer;

        protected AtomEventX2Reference()
        {
            _usage = AtomEventReferenceBase.Usage.Event;
        }

        public static implicit operator E2(AtomEventX2Reference<T, V, E1, E2, F, VI> reference)
        {
            return reference.Event;
        }
    }
}
