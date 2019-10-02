using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Color x 2", fileName = "ColorColorEvent")]
    public sealed class ColorColorEvent : AtomEvent<Color, Color> { }
}
