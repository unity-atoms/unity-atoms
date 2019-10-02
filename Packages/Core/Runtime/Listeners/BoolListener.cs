using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Bool")]
    public sealed class BoolListener : AtomListener<
        bool,
        BoolAction,
        BoolEvent,
        BoolUnityEvent>
    { }
}
