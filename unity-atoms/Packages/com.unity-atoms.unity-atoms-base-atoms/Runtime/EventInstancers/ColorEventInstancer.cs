using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `Color`. Inherits from `AtomEventInstancer&lt;Color, ColorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Color Event Instancer")]
    public class ColorEventInstancer : AtomEventInstancer<Color, ColorEvent> { }
}
