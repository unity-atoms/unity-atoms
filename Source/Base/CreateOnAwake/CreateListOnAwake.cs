
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityAtoms.Utils;

namespace UnityAtoms
{
    public class CreateListOnAwake<T, L, E, TEL, TELR, GA1, GA2, UER> : MonoBehaviour
        where L : ScriptableObjectList<T, E> where E : GameEvent<T>
        where TEL : GameEventListener<T, TELR, E, UER>
        where TELR : GameAction<T>
        where GA1 : GameAction<L> where GA2 : GameAction<L, GameObject>
        where UER : UnityEvent<T>
    {
        [SerializeField]
        private bool CreateAddedEvent = true;
        [SerializeField]
        private bool CreateRemovedEvent = true;
        [SerializeField]
        private bool CreateClearedEvent = false;

        [SerializeField]
        private TEL AddedListener = null;
        [SerializeField]
        private TEL RemovedListener = null;
        [SerializeField]
        private VoidListener ClearedListener = null;

        [SerializeField]
        private GA1 OnListCreate = null;
        [SerializeField]
        private GA2 OnListCreateWithGO = null;

        void Awake()
        {
            var list = DynamicAtoms.CreateList<T, L, E>(CreateAddedEvent, CreateRemovedEvent, CreateClearedEvent);

            if (list.Added != null)
            {
                if (AddedListener != null)
                {
                    AddedListener.GameEvent = list.Added;
                    AddedListener.GameEvent.RegisterListener(AddedListener);
                }
            }
            if (list.Removed != null)
            {
                if (RemovedListener != null)
                {
                    RemovedListener.GameEvent = list.Removed;
                    RemovedListener.GameEvent.RegisterListener(RemovedListener);
                }
            }
            if (list.Cleared != null)
            {
                if (ClearedListener != null)
                {
                    ClearedListener.GameEvent = list.Cleared;
                    ClearedListener.GameEvent.RegisterListener(ClearedListener);
                }
            }

            if (OnListCreate != null) { OnListCreate.Do(list); }
            if (OnListCreateWithGO != null) { OnListCreateWithGO.Do(list, gameObject); }
        }
    }
}
