
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
    public class CreateVariableOnAwake<T, V, E1, E2, L1, L2, GA1, GA2, GA3, GA4, UER1, UER2> : MonoBehaviour
        where V : ScriptableObjectVariable<T, E1, E2> where E1 : GameEvent<T> where E2 : GameEvent<T, T>
        where L1 : GameEventListener<T, GA1, E1, UER1> where L2 : GameEventListener<T, T, GA2, E2, UER2>
        where GA1 : GameAction<T> where GA2 : GameAction<T, T>
        where GA3 : GameAction<V> where GA4 : GameAction<V, GameObject>
        where UER1 : UnityEvent<T> where UER2 : UnityEvent<T, T>
    {
        [SerializeField]
        private bool CreateChangedEvent = true;
        [SerializeField]
        private bool CreateChangedWithHistoryEvent = false;

        [SerializeField]
        private L1 Listener;
        [SerializeField]
        private L2 ListenerWithHistory;

        [SerializeField]
        private GA3 OnVariableCreate;
        [SerializeField]
        private GA4 OnVariableCreateWithGO;

        void Awake()
        {
            var variable = VariableUtils.CreateVariable<T, V, E1, E2>(CreateChangedEvent, CreateChangedWithHistoryEvent);

            if (variable.Changed != null)
            {
                if (Listener != null)
                {
                    Listener.GameEvent = variable.Changed;
                    Listener.GameEvent.RegisterListener(Listener);
                }
            }
            if (variable.ChangedWithHistory != null)
            {
                if (ListenerWithHistory != null)
                {
                    ListenerWithHistory.GameEvent = variable.ChangedWithHistory;
                    ListenerWithHistory.GameEvent.RegisterListener(ListenerWithHistory);
                }
            }
            if (OnVariableCreate != null) { OnVariableCreate.Do(variable); }
            if (OnVariableCreateWithGO != null) { OnVariableCreateWithGO.Do(variable, gameObject); }
        }
    }
}