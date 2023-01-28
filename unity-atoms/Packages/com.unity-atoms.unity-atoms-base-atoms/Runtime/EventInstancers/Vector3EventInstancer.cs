using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Vector3`. Inherits from `AtomEventInstancer&lt;Vector3, Vector3Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Vector3 Event Instancer")]
    public class Vector3EventInstancer : AtomEventInstancer<Vector3, Vector3Event> { }
}
