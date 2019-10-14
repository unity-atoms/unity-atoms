using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Int - Int")]
    public sealed class IntIntListener : AtomListener<
        int,
        int,
        IntIntAction,
        IntIntEvent,
        IntIntUnityEvent>
    { }
}
