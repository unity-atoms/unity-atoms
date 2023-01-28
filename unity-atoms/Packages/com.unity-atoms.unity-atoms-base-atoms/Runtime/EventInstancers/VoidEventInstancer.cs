using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Void`. Inherits from `AtomEventInstancer&lt;Void, VoidEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Void Event Instancer")]
    public class VoidEventInstancer : AtomEventInstancer<Void, VoidEvent> { }
}
