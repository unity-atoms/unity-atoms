using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/Color", fileName = "SetColorVariableValueAction")]
    public sealed class SetColorVariableValue : SetVariableValue<
        Color,
        ColorVariable,
        ColorReference,
        ColorEvent,
        ColorColorEvent>
    { }
}
