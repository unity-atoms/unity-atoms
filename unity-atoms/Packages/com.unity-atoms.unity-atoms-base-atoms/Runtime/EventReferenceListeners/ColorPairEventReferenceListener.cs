using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ColorPair`. Inherits from `AtomEventReferenceListener&lt;ColorPair, ColorPairEvent, ColorPairEventReference, ColorPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ColorPair Event Reference Listener")]
    public sealed class ColorPairEventReferenceListener : AtomEventReferenceListener<
        ColorPair,
        ColorPairEvent,
        ColorPairEventReference,
        ColorPairUnityEvent>
    { }
}
