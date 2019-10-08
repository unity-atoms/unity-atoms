using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Float")]
    public sealed class FloatListener : AtomListener<
        float,
        FloatAction,
        FloatEvent,
        FloatUnityEvent>
    { }
}
