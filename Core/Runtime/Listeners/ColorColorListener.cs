using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Color`. Inherits from `AtomX2Listener&lt;Color, ColorColorAction, ColorVariable, ColorEvent, ColorColorEvent, ColorColorFunction, ColorVariableInstancer, ColorColorEventReference, ColorColorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color x 2 Listener")]
    public sealed class ColorColorListener : AtomX2Listener<
        Color,
        ColorColorAction,
        ColorVariable,
        ColorEvent,
        ColorColorEvent,
        ColorColorFunction,
        ColorVariableInstancer,
        ColorColorEventReference,
        ColorColorUnityEvent>
    { }
}
