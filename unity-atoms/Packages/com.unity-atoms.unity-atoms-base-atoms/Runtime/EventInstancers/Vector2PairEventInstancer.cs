using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Vector2Pair`. Inherits from `AtomEventInstancer&lt;Vector2Pair, Vector2PairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Vector2Pair Event Instancer")]
    public class Vector2PairEventInstancer : AtomEventInstancer<Vector2Pair, Vector2PairEvent> { }
}
