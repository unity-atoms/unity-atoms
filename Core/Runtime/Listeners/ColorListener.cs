using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Color")]
    public sealed class ColorListener : AtomListener<
        Color,
        ColorAction,
        ColorEvent,
        ColorUnityEvent>
    { }
}
