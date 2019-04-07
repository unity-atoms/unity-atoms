using UnityEngine;
using UnityEngine.Events;
using UnityAtoms.Utils;
using UnityEngine.Serialization;

namespace UnityAtoms
{
    public abstract class CreateListOnAwake<T, L, E, TEL, TELR, GA1, GA2, UER> : MonoBehaviour
        where L : ScriptableObjectList<T, E> where E : GameEvent<T>
        where TEL : GameEventListener<T, TELR, E, UER>
        where TELR : GameAction<T>
        where GA1 : GameAction<L> where GA2 : GameAction<L, GameObject>
        where UER : UnityEvent<T>
    {
        [FormerlySerializedAs("CreateAddedEvent")]
        [SerializeField]
        private bool _createAddedEvent = true;

        [FormerlySerializedAs("CreateRemovedEvent")]
        [SerializeField]
        private bool _createRemovedEvent = true;

        [FormerlySerializedAs("CreateClearedEvent")]
        [SerializeField]
        private bool _createClearedEvent;

        [FormerlySerializedAs("AddedListener")]
        [SerializeField]
        private TEL _addedListener;

        [FormerlySerializedAs("RemovedListener")]
        [SerializeField]
        private TEL _removedListener;

        [FormerlySerializedAs("ClearedListener")]
        [SerializeField]
        private VoidListener _clearedListener;

        [FormerlySerializedAs("OnListCreate")]
        [SerializeField]
        private GA1 _onListCreate;

        [FormerlySerializedAs("OnListCreateWithGO")]
        [SerializeField]
        private GA2 _onListCreateWithGO;

        private void Awake()
        {
            var list = DynamicAtoms.CreateList<T, L, E>(_createAddedEvent, _createRemovedEvent, _createClearedEvent);

            if (list.Added != null)
            {
                if (_addedListener != null)
                {
                    _addedListener.GameEvent = list.Added;
                    _addedListener.GameEvent.RegisterListener(_addedListener);
                }
            }
            if (list.Removed != null)
            {
                if (_removedListener != null)
                {
                    _removedListener.GameEvent = list.Removed;
                    _removedListener.GameEvent.RegisterListener(_removedListener);
                }
            }
            if (list.Cleared != null)
            {
                if (_clearedListener != null)
                {
                    _clearedListener.GameEvent = list.Cleared;
                    _clearedListener.GameEvent.RegisterListener(_clearedListener);
                }
            }

            if (_onListCreate != null) { _onListCreate.Do(list); }
            if (_onListCreateWithGO != null) { _onListCreateWithGO.Do(list, gameObject); }
        }
    }
}
