using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool")]
    public sealed class BoolListener : AtomListener<
        bool,
        BoolAction,
        BoolEvent,
        BoolUnityEvent>
    { }
}
