using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `Color`. Inherits from `AtomListener&lt;Color, ColorAction, ColorEvent, ColorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color")]
    public sealed class ColorListener : AtomListener<
        Color,
        ColorAction,
        ColorEvent,
        ColorUnityEvent>
    { }
}
