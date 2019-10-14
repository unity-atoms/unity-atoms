using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool - Bool")]
    public sealed class BoolBoolListener : AtomListener<
        bool,
        bool,
        BoolBoolAction,
        BoolBoolEvent,
        BoolBoolUnityEvent>
    { }
}
