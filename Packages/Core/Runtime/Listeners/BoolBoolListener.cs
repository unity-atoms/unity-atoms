using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Bool - Bool")]
    public sealed class BoolBoolListener : AtomListener<
        bool,
        bool,
        BoolBoolAction,
        BoolBoolEvent,
        BoolBoolUnityEvent>
    { }
}
