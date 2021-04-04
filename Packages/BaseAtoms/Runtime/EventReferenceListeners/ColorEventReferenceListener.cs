using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Color`. Inherits from `AtomEventReferenceListener&lt;Color, ColorEvent, ColorEventReference, ColorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color Event Reference Listener")]
    public sealed class ColorEventReferenceListener : AtomListener<Color> { }
}
