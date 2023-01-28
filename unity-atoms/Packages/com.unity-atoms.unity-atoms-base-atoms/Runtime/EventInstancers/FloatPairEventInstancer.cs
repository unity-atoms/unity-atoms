using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `FloatPair`. Inherits from `AtomEventInstancer&lt;FloatPair, FloatPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/FloatPair Event Instancer")]
    public class FloatPairEventInstancer : AtomEventInstancer<FloatPair, FloatPairEvent> { }
}
