using UnityEngine;

namespace UnityAtoms.FSM
{
    /// <summary>
    /// Event Instancer of type `FSMTransitionData`. Inherits from `AtomEventInstancer&lt;FSMTransitionData, FSMTransitionDataEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/FSMTransitionData Event Instancer")]
    public class FSMTransitionDataEventInstancer : AtomEventInstancer<FSMTransitionData, FSMTransitionDataEvent> { }
}
