using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Non-generic base class for Events.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEventBase : BaseAtom, ISerializationCallbackReceiver
    {
        /// <summary>
        /// Event without value.
        /// </summary>
        public event Action OnEventNoValue;

        /// <summary>
        /// Raise the Event.
        /// </summary>
        public virtual void Raise()
        {
#if !UNITY_ATOMS_GENERATE_DOCS && UNITY_EDITOR
            StackTraces.AddStackTrace(GetInstanceID(), StackTraceEntry.Create());
#endif
            OnEventNoValue?.Invoke();
        }

        /// <summary>
        /// Register handler to be called when the Event triggers.
        /// </summary>
        /// <param name="del">The handler.</param>
        public void Register(Action del)
        {
            OnEventNoValue += del;
        }

        /// <summary>
        /// Unregister handler that was registered using the `Register` method.
        /// </summary>
        /// <param name="del">The handler.</param>
        public void Unregister(Action del)
        {
            OnEventNoValue -= del;
        }

        /// <summary>
        /// Unregister all handlers that were registered using the `Register` method.
        /// </summary>
        public virtual void UnregisterAll()
        {
            OnEventNoValue = null;
        }

        /// <summary>
        /// Register a Listener that in turn trigger all its associated handlers when the Event triggers.
        /// </summary>
        /// <param name="listener">The Listener to register.</param>
        public void RegisterListener(IAtomListener listener)
        {
            OnEventNoValue += listener.OnEventRaised;
        }

        /// <summary>
        /// Unregister a listener that was registered using the `RegisterListener` method.
        /// </summary>
        /// <param name="listener">The Listener to unregister.</param>
        public void UnregisterListener(IAtomListener listener)
        {
            OnEventNoValue -= listener.OnEventRaised;
        }

        /// <inheritdoc />
        public void OnBeforeSerialize() { }

        /// <inheritdoc />
        public virtual void OnAfterDeserialize()
        {
            // Clear all delegates when exiting play mode
            OnEventNoValue = null;
        }
    }
}
