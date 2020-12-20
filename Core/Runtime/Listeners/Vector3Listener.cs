using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Vector3")]
    public sealed class Vector3Listener : AtomListener<
        Vector3,
        Vector3Action,
        Vector3Event,
        Vector3UnityEvent>
    { }
}
