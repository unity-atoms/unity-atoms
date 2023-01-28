using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `AtomBaseVariable`. Inherits from `AtomEventInstancer&lt;AtomBaseVariable, AtomBaseVariableEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AtomBaseVariable Event Instancer")]
    public class AtomBaseVariableEventInstancer : AtomEventInstancer<AtomBaseVariable, AtomBaseVariableEvent> { }
}
