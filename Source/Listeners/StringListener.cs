using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/String")]
    public sealed class StringListener : AtomListener<
        string,
        StringAction,
        StringEvent,
        StringUnityEvent>
    { }
}
