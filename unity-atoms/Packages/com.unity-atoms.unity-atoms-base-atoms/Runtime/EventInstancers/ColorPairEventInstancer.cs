using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `ColorPair`. Inherits from `AtomEventInstancer&lt;ColorPair, ColorPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ColorPair Event Instancer")]
    public class ColorPairEventInstancer : AtomEventInstancer<ColorPair, ColorPairEvent> { }
}
