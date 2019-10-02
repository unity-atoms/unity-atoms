using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool - Bool")]
    public sealed class BoolBoolListener : AtomListener<
        bool,
        bool,
        BoolBoolAction,
        BoolBoolEvent,
        BoolBoolUnityEvent>
    { }
}
