using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/String")]
    public sealed class StringListener : AtomListener<
        string,
        StringAction,
        StringEvent,
        StringUnityEvent>
    { }
}
