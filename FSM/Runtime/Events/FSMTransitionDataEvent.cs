using UnityEngine;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Event of type `FSMTransitionData`. Inherits from `AtomEvent&lt;FSMTransitionData&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/FSMTransitionData", fileName = "FSMTransitionDataEvent")]
    public sealed class FSMTransitionDataEvent : AtomEvent<FSMTransitionData>
    {
    }
}
