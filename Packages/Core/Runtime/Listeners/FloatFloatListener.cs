using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float - Float")]
    public sealed class FloatFloatListener : AtomListener<
        float,
        float,
        FloatFloatAction,
        FloatFloatEvent,
        FloatFloatUnityEvent>
    { }
}
