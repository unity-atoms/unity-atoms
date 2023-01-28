using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Collision2DPair`. Inherits from `AtomEventInstancer&lt;Collision2DPair, Collision2DPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Collision2DPair Event Instancer")]
    public class Collision2DPairEventInstancer : AtomEventInstancer<Collision2DPair, Collision2DPairEvent> { }
}
