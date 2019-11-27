using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `Color`. Inherits from `AtomListener&lt;Color, Color, ColorColorAction, ColorColorEvent, ColorColorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color x 2 Listener")]
    public sealed class ColorColorListener : AtomListener<
        Color,
        Color,
        ColorColorAction,
        ColorColorEvent,
        ColorColorUnityEvent>
    { }
}
