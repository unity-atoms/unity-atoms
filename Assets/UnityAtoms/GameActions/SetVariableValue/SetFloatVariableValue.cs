using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Float",
        fileName              = "SetFloatVariableValueAction", order = 1)]
    public class SetFloatVariableValue : SetVariableValue<float, FloatVariable, FloatReference, FloatEvent, FloatFloatEvent>
    {
    }
}