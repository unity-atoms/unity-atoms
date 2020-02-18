using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener of type `float`. Inherits from `AtomListener&lt;float, FloatAction, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer, FloatEventReference, FloatUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float Listener")]
    public sealed class FloatListener : AtomListener<
        float,
        FloatAction,
        FloatVariable,
        FloatEvent,
        FloatFloatEvent,
        FloatFloatFunction,
        FloatVariableInstancer,
        FloatEventReference,
        FloatUnityEvent>
    { }
}
