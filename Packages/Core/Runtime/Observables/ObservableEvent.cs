using System;
using System.Collections.Generic;

namespace UnityAtoms
{
    public class ObservableEvent<T> : IObservable<T>
    {
        private Action<Action<T>> _unregister;
        private List<IObserver<T>> _observers = new List<IObserver<T>>();

        public ObservableEvent(Action<Action<T>> register, Action<Action<T>> unregister)
        {
            register(NotifyObservers);
            _unregister = unregister;
        }

        ~ObservableEvent()
        {
            if (_unregister != null)
            {
                _unregister(NotifyObservers);
            }
        }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new ObservableUnsubscriber<T>(_observers, observer);
        }

        private void NotifyObservers(T value)
        {
            for (int i = 0; _observers != null && i < _observers.Count; ++i)
            {
                _observers[i].OnNext(value);
            }
        }
    }
}
