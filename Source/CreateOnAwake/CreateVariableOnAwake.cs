using UnityEngine;
using UnityEngine.Events;
using UnityAtoms.Utils;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class CreateVariableOnAwake<T, V, E1, E2, L1, L2, GA1, GA2, GA3, GA4, UER1, UER2> : MonoBehaviour
        where V : ScriptableObjectVariable<T, E1, E2>
        where E1 : GameEvent<T>
        where E2 : GameEvent<T, T>
        where L1 : GameEventListener<T, GA1, E1, UER1>
        where L2 : GameEventListener<T, T, GA2, E2, UER2>
        where GA1 : GameAction<T>
        where GA2 : GameAction<T, T>
        where GA3 : GameAction<V>
        where GA4 : GameAction<V, GameObject>
        where UER1 : UnityEvent<T>
        where UER2 : UnityEvent<T, T>
    {
        [FormerlySerializedAs("CreateChangedEvent")]
        [SerializeField]
        private bool _createChangedEvent = true;

        [FormerlySerializedAs("CreateChangedWithHistoryEvent")]
        [SerializeField]
        private bool _createChangedWithHistoryEvent = false;

        [FormerlySerializedAs("Listener")]
        [SerializeField]
        private L1 _listener = null;

        [FormerlySerializedAs("ListenerWithHistory")]
        [SerializeField]
        private L2 _listenerWithHistory = null;

        [FormerlySerializedAs("OnVariableCreate")]
        [SerializeField]
        private GA3 _onVariableCreate = null;

        [FormerlySerializedAs("OnVariableCreateWithGO")]
        [SerializeField]
        private GA4 _onVariableCreateWithGO = null;

        private void Awake()
        {
            var variable = DynamicAtoms.CreateVariable<T, V, E1, E2>(
                initialValue: default(T),
                changed: _createChangedEvent ? ScriptableObject.CreateInstance<E1>() : null,
                changedWithHistory: _createChangedWithHistoryEvent ? ScriptableObject.CreateInstance<E2>() : null
            );

            if (variable.Changed != null)
            {
                if (_listener != null)
                {
                    _listener.GameEvent = variable.Changed;
                    _listener.GameEvent.RegisterListener(_listener);
                }
            }
            if (variable.ChangedWithHistory != null)
            {
                if (_listenerWithHistory != null)
                {
                    _listenerWithHistory.GameEvent = variable.ChangedWithHistory;
                    _listenerWithHistory.GameEvent.RegisterListener(_listenerWithHistory);
                }
            }
            if (_onVariableCreate != null) { _onVariableCreate.Do(variable); }
            if (_onVariableCreateWithGO != null) { _onVariableCreateWithGO.Do(variable, gameObject); }
        }
    }
}
