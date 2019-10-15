using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Color`. Inherits from `AtomEvent&lt;Color&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Color", fileName = "ColorEvent")]
    public sealed class ColorEvent : AtomEvent<Color> { }
}
