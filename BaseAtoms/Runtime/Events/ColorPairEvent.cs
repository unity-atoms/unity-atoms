using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `ColorPair`. Inherits from `AtomEvent&lt;ColorPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ColorPair", fileName = "ColorPairEvent")]
    public sealed class ColorPairEvent : AtomEvent<ColorPair>
    {
    }
}
