using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color")]
    public sealed class ColorListener : AtomListener<
        Color,
        ColorAction,
        ColorEvent,
        ColorUnityEvent>
    { }
}
