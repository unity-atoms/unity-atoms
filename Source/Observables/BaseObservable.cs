using System;
using System.Collections.Generic;

namespace UnityAtoms
{
    public abstract class BaseObservable<T> : IObservable<T>
    {
        protected List<IObserver<T>> _observers = new List<IObserver<T>>();

        protected abstract bool IsCompleted { get; }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new ObservableUnsubscriber<T>(_observers, observer);
        }

        protected void OnCompleted()
        {
            if (IsCompleted)
            {
                for (int i = 0; _observers != null && i < _observers.Count; ++i)
                {
                    _observers[i].OnCompleted();
                }
            }
        }

        protected void OnError(Exception e)
        {
            for (int i = 0; _observers != null && i < _observers.Count; ++i)
            {
                _observers[i].OnError(e);
            }
        }
    }
}
