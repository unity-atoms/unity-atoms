using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Bool")]
    public sealed class BoolListener : AtomListener<
        bool,
        BoolAction,
        BoolEvent,
        BoolUnityEvent>
    { }
}
