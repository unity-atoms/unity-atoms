using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.Extensions;
using UnityAtoms.Logger;

namespace UnityAtoms
{
    public abstract class Observer<T1, V1, E1A, E1B, T2, V2, E2A, E2B, GFS>
        : ScriptableObject
        where E1A : GameEvent<T1>
        where E1B : GameEvent<T1, T1>
        where V1 : ScriptableObjectVariable<T1, E1A, E1B>
        where E2A : GameEvent<T2>
        where E2B : GameEvent<T2, T2>
        where V2 : ScriptableObjectVariable<T2, E2A, E2B>
        where GFS : GameFunction<ValueTuple<T1, T2, Action<T1, T2>>, ValueTuple<T1, T2, Action<T1, T2>>>
    {
        [SerializeField]
        private V1 _variable1;

        [SerializeField]
        private V2 _variable2;

        [SerializeField]
        private List<GFS> _gameFunctions;

        private Action<T1> _cachedAction1;

        private Action<T2> _cachedAction2;

        private void Updater(T1 t1, T2 t2)
        {
            _variable1.SetValue(t1);
            _variable2.SetValue(t2);
        }

        public void Init(V1 v1, V2 v2, List<GFS> funcs)
        {
            _variable1 = v1;
            _variable2 = v2;
            _gameFunctions = funcs;

            if (_variable1.Changed == null || _variable2.Changed == null)
            {
                AtomsLogger.Error("You need to add a Changed / Added / Removed / Cleared event to each Variable / List when observing them.");
                return;
            }

            if (_gameFunctions == null || _gameFunctions.Count <= 0)
            {
                AtomsLogger.Error("You need to give the observer at least one GameFunction.");
                return;
            }

            var functionPipe = _gameFunctions.Pipe<ValueTuple<T1, T2, Action<T1, T2>>, GFS>();
            _cachedAction1 = (item) =>
            {
                functionPipe(new ValueTuple<T1, T2, Action<T1, T2>>(item, _variable2.Value, Updater));
            };
            _cachedAction2 = (item) =>
            {
                functionPipe(new ValueTuple<T1, T2, Action<T1, T2>>(_variable1.Value, item, Updater));
            };

            _variable1.Changed.OnEvent += _cachedAction1;
            _variable2.Changed.OnEvent += _cachedAction2;

            functionPipe(new ValueTuple<T1, T2, Action<T1, T2>>(_variable1.Value, _variable2.Value, Updater));
        }

        public void UnregisterListeners()
        {
            if (_variable1.Changed != null) _variable1.Changed.OnEvent -= _cachedAction1;
            if (_variable2.Changed != null) _variable2.Changed.OnEvent -= _cachedAction2;
        }

        private void OnEnable()
        {
            if (_variable1 != null && _variable2 != null && _gameFunctions != null && _gameFunctions.Count > 0)
            {
                Init(_variable1, _variable2, _gameFunctions);
            }
        }

        private void OnDisable()
        {
            UnregisterListeners();
        }
    }

    public abstract class Observer<T1, V1, E1A, E1B, T2, V2, E2A, E2B, T3, L3, E3, GFS>
        : ScriptableObject
        where E1A : GameEvent<T1>
        where E1B : GameEvent<T1, T1>
        where V1 : ScriptableObjectVariable<T1, E1A, E1B>
        where E2A : GameEvent<T2>
        where E2B : GameEvent<T2, T2>
        where V2 : ScriptableObjectVariable<T2, E2A, E2B>
        where L3 : ScriptableObjectList<T3, E3>
        where E3 : GameEvent<T3>
        where GFS : GameFunction<ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>, ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>>
    {
        [SerializeField]
        private V1 _variable1;

        [SerializeField]
        private V2 _variable2;

        [SerializeField]
        private L3 _list;

        [SerializeField]
        private List<GFS> _gameFunctions;

        private Action<T1> _cachedAction1;

        private Action<T2> _cachedAction2;

        private Action<T3> _cachedAddedAction;
        private Action<T3> _cachedRemovedAction;
        private Action<UnityAtoms.Void> _cachedClearedAction;

        private void Updater(T1 t1, T2 t2, List<T3> l3)
        {
            _variable1.SetValue(t1);
            _variable2.SetValue(t2);
            _list.List = l3;
        }

        public void Init(V1 v1, V2 v2, L3 l3, List<GFS> funcs)
        {
            _variable1 = v1;
            _variable2 = v2;
            _list = l3;
            _gameFunctions = funcs;

            if (_variable1.Changed == null || _variable2.Changed == null || (_list.Added == null && _list.Removed == null && _list.Cleared == null))
            {
                AtomsLogger.Error("You need to add a Changed / Added / Removed / Cleared event to each Variable / List when observing them.");
                return;
            }

            if (_gameFunctions == null || _gameFunctions.Count <= 0)
            {
                AtomsLogger.Error("You need to give the observer at least one GameFunction.");
                return;
            }

            var functionPipe = _gameFunctions.Pipe<ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>, GFS>();
            _cachedAction1 = (item) =>
            {
                functionPipe(new ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>(item, _variable2.Value, _list.List, Updater));
            };
            _cachedAction2 = (item) =>
            {
                functionPipe(new ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>(_variable1.Value, item, _list.List, Updater));
            };
            _cachedAddedAction = (list) =>
            {
                functionPipe(new ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>(_variable1.Value, _variable2.Value, _list.List, Updater));
            };
            _cachedRemovedAction = (list) =>
            {
                functionPipe(new ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>(_variable1.Value, _variable2.Value, _list.List, Updater));
            };
            _cachedClearedAction = (_) =>
            {
                functionPipe(new ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>(_variable1.Value, _variable2.Value, _list.List, Updater));
            };

            _variable1.Changed.OnEvent += _cachedAction1;
            _variable2.Changed.OnEvent += _cachedAction2;

            if (_list.Added != null) _list.Added.OnEvent += _cachedAddedAction;
            if (_list.Removed != null) _list.Removed.OnEvent += _cachedRemovedAction;
            if (_list.Cleared != null) _list.Cleared.OnEvent += _cachedClearedAction;

            functionPipe(new ValueTuple<T1, T2, List<T3>, Action<T1, T2, List<T3>>>(_variable1.Value, _variable2.Value, _list.List, Updater));
        }

        public void UnregisterListeners()
        {
            if (_variable1.Changed != null) _variable1.Changed.OnEvent -= _cachedAction1;
            if (_variable2.Changed != null) _variable2.Changed.OnEvent -= _cachedAction2;
            if (_list.Added != null) _list.Added.OnEvent -= _cachedAddedAction;
            if (_list.Removed != null) _list.Removed.OnEvent -= _cachedRemovedAction;
            if (_list.Cleared != null) _list.Cleared.OnEvent -= _cachedClearedAction;
        }

        private void OnEnable()
        {
            if (_variable1 != null && _variable2 != null && _list != null && _gameFunctions != null && _gameFunctions.Count > 0)
            {
                Init(_variable1, _variable2, _list, _gameFunctions);
            }
        }

        private void OnDisable()
        {
            UnregisterListeners();
        }
    }
}
