using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Different types of Event Reference usages.
    /// </summary>
    public class AtomEventReferenceUsage
    {
        public const int EVENT = 0;
        public const int EVENT_INSTANCER = 1;
        public const int VARIABLE = 2;
        public const int VARIABLE_INSTANCER = 3;
    }

    /// <summary>
    /// Base class for Event References.
    /// </summary>
    public abstract class AtomBaseEventReference
    {
        /// <summary>
        /// Describes how we use the Event Reference.
        /// </summary>
        [SerializeField]
        protected int _usage;
    }

    /// <summary>
    /// An Event Reference lets you define an event in your script where you then from the inspector can choose if it's going to use the Event from an Event, Event Instancer, Variable or a Variable Instancer.
    /// </summary>
    /// <typeparam name="T">The type of the event.</typeparam>
    public abstract class AtomBaseEventReference<T> : AtomBaseEventReference
    {
        /// <summary>
        /// Get the event for the Event Reference.
        /// </summary>
        /// <value>The event of type `E`.</value>
        public virtual AtomEvent<T> Event
        {
            get
            {
                switch (_usage)
                {
                    case (AtomEventReferenceUsage.EVENT_INSTANCER): return _eventInstancer.Event;
                    case (AtomEventReferenceUsage.EVENT): return _event;
                    default:
                        throw new NotSupportedException($"Event not possible to retrieve for usage {_usage}.");
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomEventReferenceUsage.EVENT):
                        _event = value;
                        break;
                    case (AtomEventReferenceUsage.EVENT_INSTANCER):
                        _eventInstancer.Event = value;
                        break;
                    default:
                        throw new NotSupportedException($"Event not reassignable for usage {_usage}.");
                }
            }
        }

        /// <summary>
        /// Event used if `Usage` is set to `Event`.
        /// </summary>
        [SerializeField]
        protected AtomEvent<T> _event = default(AtomEvent<T>);

        /// <summary>
        /// EventInstancer used if `Usage` is set to `EventInstancer`.
        /// </summary>
        [SerializeField]
        protected AtomEventInstancer<T> _eventInstancer = default(AtomEventInstancer<T>);

        protected AtomBaseEventReference()
        {
            _usage = AtomEventReferenceUsage.EVENT;
        }

        public static implicit operator AtomEvent<T>(AtomBaseEventReference<T> reference)
        {
            return reference.Event;
        }
    }
}