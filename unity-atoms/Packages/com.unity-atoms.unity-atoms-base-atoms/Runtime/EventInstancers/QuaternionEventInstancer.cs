using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Quaternion`. Inherits from `AtomEventInstancer&lt;Quaternion, QuaternionEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Quaternion Event Instancer")]
    public class QuaternionEventInstancer : AtomEventInstancer<Quaternion, QuaternionEvent> { }
}
