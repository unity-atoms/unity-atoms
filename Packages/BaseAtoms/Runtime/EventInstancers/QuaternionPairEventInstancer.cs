using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `QuaternionPair`. Inherits from `AtomEventInstancer&lt;QuaternionPair, QuaternionPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/QuaternionPair Event Instancer")]
    public class QuaternionPairEventInstancer : AtomEventInstancer<QuaternionPair, QuaternionPairEvent> { }
}
