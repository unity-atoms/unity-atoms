using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Void")]
    public sealed class VoidListener : AtomListener<
        Void,
        VoidAction,
        VoidEvent,
        VoidUnityEvent>
    { }
}
