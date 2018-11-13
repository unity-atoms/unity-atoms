using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/Float")]
    public class SetFloatVariableValue : SetVariableValue<float, FloatVariable, FloatReference, FloatEvent, FloatFloatEvent> { }
}