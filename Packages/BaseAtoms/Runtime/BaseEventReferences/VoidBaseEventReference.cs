using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    public class VoidBaseEventReferenceUsage
    {
        public const int EVENT = 0;
        public const int EVENT_INSTANCER = 1;
        public const int COLLECTION_CLEARED_EVENT = 2;
        public const int LIST_CLEARED_EVENT = 3;
        public const int COLLECTION_INSTANCER_CLEARED_EVENT = 4;
        public const int LIST_INSTANCER_CLEARED_EVENT = 5;
    }

    /// <summary>
    /// Event Reference of type `Void`. Inherits from `AtomBaseEventReference&lt;Void, VoidEvent, VoidEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class VoidBaseEventReference : AtomBaseEventReference<
        Void,
        VoidEvent,
        VoidEventInstancer>, IGetEvent
    {
        /// <summary>
        /// Get or set the Event used by the Event Reference.
        /// </summary>
        /// <value>The event of type `E`.</value>
        public override VoidEvent Event
        {
            get
            {
                switch (_usage)
                {
                    case (VoidBaseEventReferenceUsage.COLLECTION_CLEARED_EVENT): return _collection != null ? _collection.Cleared : null;
                    case (VoidBaseEventReferenceUsage.LIST_CLEARED_EVENT): return _list != null ? _list.Cleared : null;
                    case (VoidBaseEventReferenceUsage.COLLECTION_INSTANCER_CLEARED_EVENT): return _collectionInstancer != null ? _collectionInstancer.Cleared : null;
                    case (VoidBaseEventReferenceUsage.LIST_INSTANCER_CLEARED_EVENT): return _listInstancer != null ? _listInstancer.Cleared : null;
                    case (VoidBaseEventReferenceUsage.EVENT_INSTANCER): return _eventInstancer != null ? _eventInstancer.Event : null;
                    case (VoidBaseEventReferenceUsage.EVENT):
                    default:
                        return _event;
                }
            }
            set
            {
                switch (_usage)
                {
                    case (VoidBaseEventReferenceUsage.COLLECTION_CLEARED_EVENT):
                        {
                            _collection.Cleared = value;
                            break;
                        }
                    case (VoidBaseEventReferenceUsage.LIST_CLEARED_EVENT):
                        {
                            _list.Cleared = value;
                            break;
                        }
                    case (VoidBaseEventReferenceUsage.COLLECTION_INSTANCER_CLEARED_EVENT):
                        {
                            _collectionInstancer.Cleared = value;
                            break;
                        }
                    case (VoidBaseEventReferenceUsage.LIST_INSTANCER_CLEARED_EVENT):
                        {
                            _listInstancer.Cleared = value;
                            break;
                        }
                    case (VoidBaseEventReferenceUsage.EVENT):
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
        /// Collection used if `Usage` is set to `COLLECTION_CLEARED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomCollection _collection = default(AtomCollection);

        /// <summary>
        /// List used if `Usage` is set to `LIST_CLEARED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomList _list = default(AtomList);

        /// <summary>
        /// Collection Instancer used if `Usage` is set to `COLLECTION_INSTANCER_CLEARED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomCollectionInstancer _collectionInstancer = default(AtomCollectionInstancer);

        /// <summary>
        /// List Instancer used if `Usage` is set to `LIST_INSTANCER_CLEARED_EVENT`.
        /// </summary>
        [SerializeField]
        private AtomListInstancer _listInstancer = default(AtomListInstancer);
    }
}
