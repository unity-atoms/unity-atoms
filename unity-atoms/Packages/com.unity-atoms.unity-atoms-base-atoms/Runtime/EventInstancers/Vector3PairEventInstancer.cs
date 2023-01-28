using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Vector3Pair`. Inherits from `AtomEventInstancer&lt;Vector3Pair, Vector3PairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Vector3Pair Event Instancer")]
    public class Vector3PairEventInstancer : AtomEventInstancer<Vector3Pair, Vector3PairEvent> { }
}
