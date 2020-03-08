using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Event of type `TransitionData`. Inherits from `AtomEvent&lt;TransitionData&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/FSM/Transition Event", fileName = "TransitionEvent")]
    public sealed class TransitionEvent : AtomEvent<TransitionData> { }
}