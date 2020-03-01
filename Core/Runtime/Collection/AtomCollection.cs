using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// A Collection / Dictionary of Atom Variables (AtomBaseVariable).
    /// </summary>
    // [CreateAssetMenu(menuName = "Unity Atoms/Collection", fileName = "Collection")]
    // [EditorIcon("atom-icon-kingsyellow")]
    // public class AtomCollection : AtomBaseVariable<StringReferenceAtomBaseVariableDictionary>
    // {
    //     /// <summary>
    //     /// Event for when and item is added to the collection.
    //     /// </summary>
    //     public AtomBaseVariableEvent Added { get => _added; set => _added = value; }

    //     /// <summary>
    //     /// Event for when and item is removed from the collection.
    //     /// </summary>
    //     public AtomBaseVariableEvent Removed { get => _removed; set => _removed = value; }

    //     /// <summary>
    //     /// Event for when the collection is cleared.
    //     /// </summary>
    //     public VoidEvent Cleared { get => _cleared; set => _cleared = value; }

    //     [SerializeField]
    //     private AtomBaseVariableEvent _added;

    //     [SerializeField]
    //     private AtomBaseVariableEvent _removed;

    //     [SerializeField]
    //     private VoidEvent _cleared;

    //     void OnEnable()
    //     {
    //         if (Value == null) return;

    //         Value.Added += PropogateAdded;
    //         Value.Removed += PropogateRemoved;
    //         Value.Cleared += PropogateCleared;
    //     }

    //     void OnDisable()
    //     {
    //         if (Value == null) return;

    //         Value.Added -= PropogateAdded;
    //         Value.Removed -= PropogateRemoved;
    //         Value.Cleared -= PropogateCleared;
    //     }

    //     void PropogateAdded(AtomBaseVariable baseVariable)
    //     {
    //         if (_added == null) return;

    //         _added.Raise(baseVariable);
    //     }

    //     void PropogateRemoved(AtomBaseVariable baseVariable)
    //     {
    //         if (_removed == null) return;

    //         _removed.Raise(baseVariable);
    //     }

    //     void PropogateCleared()
    //     {
    //         if (_cleared == null) return;

    //         _cleared.Raise();
    //     }

    //     #region Observable
    //     /// <summary>
    //     /// Make the add event into an `IObservable&lt;T&gt;`. Makes Collection's add Event compatible with for example UniRx.
    //     /// </summary>
    //     /// <returns>The add Event as an `IObservable&lt;T&gt;`.</returns>
    //     public IObservable<AtomBaseVariable> ObserveAdd()
    //     {
    //         if (Added == null)
    //         {
    //             throw new Exception("You must assign an Added event in order to observe when adding to the collection.");
    //         }

    //         return new ObservableEvent<AtomBaseVariable>(Added.Register, Added.Unregister);
    //     }

    //     /// <summary>
    //     /// Make the remove event into an `IObservable&lt;T&gt;`. Makes Collection's remove Event compatible with for example UniRx.
    //     /// </summary>
    //     /// <returns>The remove Event as an `IObservable&lt;T&gt;`.</returns>
    //     public IObservable<AtomBaseVariable> ObserveRemove()
    //     {
    //         if (Removed == null)
    //         {
    //             throw new Exception("You must assign a Removed event in order to observe when removing from the collection.");
    //         }

    //         return new ObservableEvent<AtomBaseVariable>(Removed.Register, Removed.Unregister);
    //     }

    //     /// <summary>
    //     /// Make the clear event into an `IObservable&lt;Void&gt;`. Makes Collection's clear Event compatible with for example UniRx.
    //     /// </summary>
    //     /// <returns>The clear Event as an `IObservable&lt;Void&gt;`.</returns>
    //     public IObservable<Void> ObserveClear()
    //     {
    //         if (Cleared == null)
    //         {
    //             throw new Exception("You must assign a Cleared event in order to observe when clearing the collection.");
    //         }

    //         return new ObservableVoidEvent(Cleared.Register, Cleared.Unregister);
    //     }

    //     #endregion // Observable
    // }
}