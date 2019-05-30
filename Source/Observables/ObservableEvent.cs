using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    internal class ObservableEvent<T> : IObservable<T>
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

    internal class ObservableEvent<T1, T2, M> : IObservable<M>
    {
        private Action<Action<T1, T2>> _unregister;
        private List<IObserver<M>> _observers = new List<IObserver<M>>();
        private Func<T1, T2, M> _createCombinedModel;

        public ObservableEvent(Action<Action<T1, T2>> register, Action<Action<T1, T2>> unregister, Func<T1, T2, M> createCombinedModel)
        {
            register(NotifyObservers);
            _unregister = unregister;
            _createCombinedModel = createCombinedModel;
        }

        ~ObservableEvent()
        {
            if (_unregister != null)
            {
                _unregister(NotifyObservers);
            }
        }

        public IDisposable Subscribe(IObserver<M> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new ObservableUnsubscriber<M>(_observers, observer);
        }

        private void NotifyObservers(T1 value1, T2 value2)
        {
            for (int i = 0; _observers != null && i < _observers.Count; ++i)
            {
                _observers[i].OnNext(_createCombinedModel(value1, value2));
            }
        }
    }
}
