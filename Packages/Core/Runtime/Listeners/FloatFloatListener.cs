using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Listener x 2 of type `float`. Inherits from `AtomX2Listener&lt;float, FloatFloatAction, FloatVariable, FloatEvent, FloatFloatEvent, FloatFloatFunction, FloatVariableInstancer, FloatFloatEventReference, FloatFloatUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Float x 2 Listener")]
    public sealed class FloatFloatListener : AtomX2Listener<
        float,
        FloatFloatAction,
        FloatVariable,
        FloatEvent,
        FloatFloatEvent,
        FloatFloatFunction,
        FloatVariableInstancer,
        FloatFloatEventReference,
        FloatFloatUnityEvent>
    { }
}
