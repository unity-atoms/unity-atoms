using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// A Collection / Dictionary of Atom Variables (AtomBaseVariable).
    /// </summary>
    [CreateAssetMenu(menuName = "Unity Atoms/Collection", fileName = "Collection")]
    [EditorIcon("atom-icon-kingsyellow")]
    public class AtomCollection : AtomBaseVariable<StringReferenceAtomBaseVariableDictionary>
    {
        [SerializeField]
        private AtomBaseVariableEvent _added;

        [SerializeField]
        private AtomBaseVariableEvent _removed;

        [SerializeField]
        private VoidEvent _cleared;

        void OnEnable()
        {
            if (Value == null) return;

            Value.Added += PropogateAdded;
            Value.Removed += PropogateRemoved;
            Value.Cleared += PropogateCleared;
        }

        void OnDisable()
        {
            if (Value == null) return;

            Value.Added -= PropogateAdded;
            Value.Removed -= PropogateRemoved;
            Value.Cleared -= PropogateCleared;
        }

        void PropogateAdded(AtomBaseVariable baseVariable)
        {
            if (_added == null) return;

            _added.Raise(baseVariable);
        }

        void PropogateRemoved(AtomBaseVariable baseVariable)
        {
            if (_removed == null) return;

            _removed.Raise(baseVariable);
        }

        void PropogateCleared()
        {
            if (_cleared == null) return;

            _cleared.Raise();
        }
    }
}