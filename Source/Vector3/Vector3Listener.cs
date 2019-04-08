using UnityEngine;

namespace UnityAtoms
{
    public sealed class Vector3Listener : GameEventListener<
        Vector3,
        Vector3Action,
        Vector3Event,
        UnityVector3Event>
    { }
}
