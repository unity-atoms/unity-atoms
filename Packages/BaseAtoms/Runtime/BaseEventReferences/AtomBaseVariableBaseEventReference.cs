using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Different types of Event Reference usages.
    /// </summary>
    public class AtomBaseVariableEventReferenceUsage
    {
        public const int EVENT = 0;
        public const int EVENT_INSTANCER = 1;
        public const int COLLECTION_ADDED_EVENT = 2;
        public const int COLLECTION_REMOVED_EVENT = 3;
        public const int LIST_ADDED_EVENT = 4;
        public const int LIST_REMOVED_EVENT = 5;
        public const int COLLECTION_INSTANCER_ADDED_EVENT = 6;
        public const int COLLECTION_INSTANCER_REMOVED_EVENT = 7;
        public const int LIST_INSTANCER_ADDED_EVENT = 8;
        public const int LIST_INSTANCER_REMOVED_EVENT = 9;
    }

    /// <summary>
    /// Event Reference of type `AtomBaseVariable`. Inherits from `AtomBaseEventReference&lt;AtomBaseVariable, AtomBaseVariableEvent, AtomBaseVariableEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AtomBaseVariableBaseEventReference : AtomBaseEventReference<
        AtomBaseVariable,
        AtomBaseVariableEvent,
        AtomBaseVariableEventInstancer>, IGetEvent
    {
        /// <summary>
        /// Get or set the Event used by the Event Reference.
        /// </summary>
        /// <value>The event of type `E`.</value>
        public override AtomBaseVariableEvent Event
        {
            get
            {
                switch (_usage)
                {
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_ADDED_EVENT): return _collection != null ? _collection.Added : null;
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_REMOVED_EVENT): return _collection != null ? _collection.Removed : null;
                    case (AtomBaseVariableEventReferenceUsage.LIST_ADDED_EVENT): return _list != null ? _list.Added : null;
                    case (AtomBaseVariableEventReferenceUsage.LIST_REMOVED_EVENT): return _list != null ? _list.Removed : null;
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_INSTANCER_ADDED_EVENT): return _collectionInstancer != null ? _collectionInstancer.Added : null;
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_INSTANCER_REMOVED_EVENT): return _collectionInstancer != null ? _collectionInstancer.Removed : null;
                    case (AtomBaseVariableEventReferenceUsage.LIST_INSTANCER_ADDED_EVENT): return _listInstancer != null ? _listInstancer.Added : null;
                    case (AtomBaseVariableEventReferenceUsage.LIST_INSTANCER_REMOVED_EVENT): return _listInstancer != null ? _listInstancer.Removed : null;
                    case (AtomBaseVariableEventReferenceUsage.EVENT_INSTANCER): return _eventInstancer != null ? _eventInstancer.Event : null;
                    case (AtomBaseVariableEventReferenceUsage.EVENT):
                    default:
                        return _event;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_ADDED_EVENT):
                        {
                            _collection.Added = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_REMOVED_EVENT):
                        {
                            _collection.Removed = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.LIST_ADDED_EVENT):
                        {
                            _list.Added = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.LIST_REMOVED_EVENT):
                        {
                            _list.Removed = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_INSTANCER_ADDED_EVENT):
                        {
                            _collectionInstancer.Added = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.COLLECTION_INSTANCER_REMOVED_EVENT):
                        {
                            _collectionInstancer.Removed = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.LIST_INSTANCER_ADDED_EVENT):
                        {
                            _listInstancer.Added = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.LIST_INSTANCER_REMOVED_EVENT):
                        {
                            _listInstancer.Removed = value;
                            break;
                        }
                    case (AtomBaseVariableEventReferenceUsage.EVENT):
                        {
                            _event = value;
                            break;
                        }
                    default:
                        throw new NotSupportedException($"Event not reassignable for usage {_usage}.");
                }
            }
        }

        /// <summary>
        /// Collection used if `Usage` is set to `COLLECTION_ADDED_EVENT` or `COLLECTION_REMOVED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomCollection _collection = default(AtomCollection);

        /// <summary>
        /// List used if `Usage` is set to `LIST_ADDED_EVENT` or `LIST_REMOVED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomList _list = default(AtomList);

        /// <summary>
        /// Collection Instancer used if `Usage` is set to `COLLECTION_INSTANCER_ADDED_EVENT` or `COLLECTION_INSTANCER_REMOVED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomCollectionInstancer _collectionInstancer = default(AtomCollectionInstancer);

        /// <summary>
        /// List Instancer used if `Usage` is set to `LIST_INSTANCER_ADDED_EVENT` or `LIST_INSTANCER_REMOVED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomListInstancer _listInstancer = default(AtomListInstancer);
    }
}
