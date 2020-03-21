using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `IntPair`. Inherits from `AtomEventInstancer&lt;IntPair, IntPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/IntPair Event Instancer")]
    public class IntPairEventInstancer : AtomEventInstancer<IntPair, IntPairEvent> { }
}
