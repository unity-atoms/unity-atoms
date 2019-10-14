using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Color", fileName = "ColorEvent")]
    public sealed class ColorEvent : AtomEvent<Color> { }
}
