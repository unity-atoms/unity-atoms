using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Color")]
    public sealed class ColorListener : AtomListener<
        Color,
        ColorAction,
        ColorEvent,
        ColorUnityEvent>
    { }
}
