using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEvent : BaseAtom, ISerializationCallbackReceiver
    {
        public event Action OnEventNoValue;
        protected void RaiseNoValue()
        {
            OnEventNoValue?.Invoke();
        }

        public void Register(Action del)
        {
            OnEventNoValue += del;
        }

        public void Unregister(Action del)
        {
            OnEventNoValue -= del;
        }

        public void OnBeforeSerialize() { }

        public virtual void OnAfterDeserialize()
        {
            // Clear all delegates when exiting play mode
            if (OnEventNoValue != null)
            {
                foreach (var d in OnEventNoValue.GetInvocationList())
                {
                    OnEventNoValue -= (Action)d;
                }
            }
        }

    }

    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEvent<T> : AtomEvent
    {
        public event Action<T> OnEvent;

        public void Raise(T item)
        {
            base.RaiseNoValue();
            OnEvent?.Invoke(item);
        }

        public void Register(Action<T> del)
        {
            OnEvent += del;
        }

        public void Unregister(Action<T> del)
        {
            OnEvent -= del;
        }

        public void RegisterListener(IAtomListener<T> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        public void UnregisterListener(IAtomListener<T> listener)
        {
            OnEvent -= listener.OnEventRaised;
        }

        #region Observable
        public IObservable<T> Observe()
        {
            return new ObservableEvent<T>(Register, Unregister);
        }
        #endregion // Observable

        public override void OnAfterDeserialize()
        {
            base.OnAfterDeserialize();
            // Clear all delegates when exiting play mode
            if (OnEvent != null)
            {
                foreach (var d in OnEvent.GetInvocationList())
                {
                    OnEvent -= (Action<T>)d;
                }
            }
        }
    }

    [EditorIcon("atom-icon-cherry")]
    public abstract class AtomEvent<T1, T2> : AtomEvent
    {
        public event Action<T1, T2> OnEvent;

        public void Raise(T1 item1, T2 item2)
        {
            base.RaiseNoValue();
            OnEvent?.Invoke(item1, item2);
        }

        public void Register(Action<T1, T2> del)
        {
            OnEvent += del;
        }

        public void Unregister(Action<T1, T2> del)
        {
            OnEvent -= del;
        }

        public void RegisterListener(IAtomListener<T1, T2> listener)
        {
            OnEvent += listener.OnEventRaised;
        }

        public void UnregisterListener(IAtomListener<T1, T2> listener)
        {
            OnEvent -= listener.OnEventRaised;
        }

        #region Observable
        public IObservable<M> Observe<M>(Func<T1, T2, M> createCombinedModel)
        {
            return new ObservableEvent<T1, T2, M>(Register, Unregister, createCombinedModel);
        }
        #endregion // Observable

        public override void OnAfterDeserialize()
        {
            base.OnAfterDeserialize();
            // Clear all delegates when exiting play mode
            if (OnEvent != null)
                foreach (var d in OnEvent.GetInvocationList())
                {
                    OnEvent -= (Action<T1, T2>)d;
                }
        }
    }
}
