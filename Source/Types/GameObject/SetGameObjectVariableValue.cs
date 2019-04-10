using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Set Variable", fileName = "SetGameObjectVariableValueAction", order = CreateAssetMenuUtils.Order.SET_VARIABLE)]
    public sealed class SetGameObjectVariableValue : SetVariableValue<
        GameObject,
        GameObjectVariable,
        GameObjectReference,
        GameObjectEvent,
        GameObjectGameObjectEvent>
    { }
}
