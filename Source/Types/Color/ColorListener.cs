using UnityEngine;

namespace UnityAtoms
{
    public sealed class ColorListener : GameEventListener<
        Color,
        ColorAction,
        ColorEvent,
        UnityColorEvent>
    { }
}
