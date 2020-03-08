using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// The most basic Listener. Can use every type of AtomEvent but doesn't support its value. Inherits from `AtomBaseListener` and implements `IAtomListener`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Void Base Event Reference Listener")]
    public sealed class VoidListener : AtomEventReferenceListener<
        Void,
        VoidAction,
        VoidEvent,
        VoidBaseEventReference,
        VoidUnityEvent>
    { }
}