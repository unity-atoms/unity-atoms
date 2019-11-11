using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `float`. Inherits from `AtomListener&lt;float, float, FloatFloatAction, FloatFloatEvent, FloatFloatUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float Float Listener")]
    public sealed class FloatFloatListener : AtomListener<
        float,
        float,
        FloatFloatAction,
        FloatFloatEvent,
        FloatFloatUnityEvent>
    { }
}
