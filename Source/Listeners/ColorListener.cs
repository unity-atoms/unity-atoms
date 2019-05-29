using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Color")]
    public sealed class ColorListener : GameEventListener<
        Color,
        ColorAction,
        ColorEvent,
        UnityColorEvent>
    { }
}
