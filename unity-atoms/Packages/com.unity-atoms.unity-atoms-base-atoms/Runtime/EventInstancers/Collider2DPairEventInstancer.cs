using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collider2DPair`. Inherits from `AtomEventInstancer&lt;Collider2DPair, Collider2DPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collider2DPair Event Instancer")]
    public class Collider2DPairEventInstancer : AtomEventInstancer<Collider2DPair, Collider2DPairEvent> { }
}
