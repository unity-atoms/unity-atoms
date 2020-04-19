using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `bool`. Inherits from `AtomEventInstancer&lt;bool, BoolEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Bool Event Instancer")]
    public class BoolEventInstancer : AtomEventInstancer<bool, BoolEvent> { }
}
