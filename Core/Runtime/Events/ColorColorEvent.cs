using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 of type `Color`. Inherits from `AtomEvent&lt;Color, Color&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Color x 2", fileName = "ColorColorEvent")]
    public sealed class ColorColorEvent : AtomEvent<Color, Color> { }
}
