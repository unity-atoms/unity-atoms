using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// An Event Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event, Event Instancer, Variable or a Variable Instancer.
    /// </summary>
    /// <typeparam name="T">The type of the event.</typeparam>
    [Serializable]
    public class AtomEventReference<T> : AtomBaseEventReference<T>
    {
        /// <summary>
        /// Get or set the Event used by the Event Reference.
        /// </summary>
        /// <value>The event of type `E`.</value>
        public override AtomEvent<T> Event
        {
            get
            {
                switch (_usage)
                {
                    case (AtomEventReferenceUsage.VARIABLE): return _variable.GetEvent<AtomEvent<T>>();
                    case (AtomEventReferenceUsage.VARIABLE_INSTANCER): return _variableInstancer.GetEvent<AtomEvent<T>>();
                    default: return base.Event;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomEventReferenceUsage.VARIABLE):
                        _variable.SetEvent(value);
                        break;
                    case (AtomEventReferenceUsage.VARIABLE_INSTANCER):
                        _variableInstancer.SetEvent(value);
                        break;
                    default:
                        base.Event = value;
                        break;
                }
            }
        }

        /// <summary>
        /// Variable used if `Usage` is set to `Variable`.
        /// </summary>
        [SerializeField]
        private AtomVariable<T> _variable = default(AtomVariable<T>);

        /// <summary>
        /// Variable Instancer used if `Usage` is set to `VariableInstancer`.
        /// </summary>
        [SerializeField]
        private AtomVariableInstancer<T> _variableInstancer = default(AtomVariableInstancer<T>);
    }
}
