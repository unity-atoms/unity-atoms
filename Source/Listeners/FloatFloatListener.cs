using UnityEngine;

namespace UnityAtoms
{
    [AddComponentMenu("Unity Atoms/Listeners/Float - Float")]
    public sealed class FloatFloatListener : AtomListener<
        float,
        float,
        FloatFloatAction,
        FloatFloatEvent,
        FloatFloatUnityEvent>
    { }
}
