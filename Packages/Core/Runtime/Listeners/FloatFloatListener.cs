using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float - Float")]
    public sealed class FloatFloatListener : AtomListener<
        float,
        float,
        FloatFloatAction,
        FloatFloatEvent,
        FloatFloatUnityEvent>
    { }
}
