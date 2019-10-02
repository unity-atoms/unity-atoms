using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector3 - Vector3")]
    public sealed class Vector3Vector3Listener : AtomListener<
        Vector3,
        Vector3,
        Vector3Vector3Action,
        Vector3Vector3Event,
        Vector3Vector3UnityEvent>
    { }
}
