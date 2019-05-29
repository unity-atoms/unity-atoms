using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Bool")]
    public sealed class BoolListener : GameEventListener<
        bool,
        BoolAction,
        BoolEvent,
        UnityBoolEvent>
    { }
}
