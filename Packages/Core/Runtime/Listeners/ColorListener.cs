using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Color`. Inherits from `AtomListener&lt;Color, ColorAction, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer, ColorEventReference, ColorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color Listener")]
    public sealed class ColorListener : AtomListener<
        Color,
        ColorAction,
        ColorVariable,
        ColorEvent,
        ColorColorEvent,
        ColorColorFunction,
        ColorVariableInstancer,
        ColorEventReference,
        ColorUnityEvent>
    { }
}
