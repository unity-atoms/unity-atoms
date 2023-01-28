using System;
using System.Collections.Generic;

namespace UnityAtoms
{
    public class ObservableVoidEvent : IObservable<Void>
    {
        private Action<Action> _unregister = default(Action<Action>);
        private List<IObserver<Void>> _observers = new List<IObserver<Void>>();

        public ObservableVoidEvent(Action<Action> register, Action<Action> unregister)
        {
            register(NotifyObservers);
        }

        ~ObservableVoidEvent()
        {
            if (_unregister != null)
            {
                _unregister(NotifyObservers);
            }
        }

        public IDisposable Subscribe(IObserver<Void> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new ObservableUnsubscriber<Void>(_observers, observer);
        }

        private void NotifyObservers()
        {
            for (int i = 0; _observers != null && i < _observers.Count; ++i)
            {
                _observers[i].OnNext(new Void());
            }
        }
    }
}