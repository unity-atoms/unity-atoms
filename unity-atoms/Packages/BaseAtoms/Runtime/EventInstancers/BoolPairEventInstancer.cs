using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `BoolPair`. Inherits from `AtomEventInstancer&lt;BoolPair, BoolPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/BoolPair Event Instancer")]
    public class BoolPairEventInstancer : AtomEventInstancer<BoolPair, BoolPairEvent> { }
}
