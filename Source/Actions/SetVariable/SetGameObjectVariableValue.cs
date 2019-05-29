using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/GameObject", fileName = "SetGameObjectVariableValueAction")]
    public sealed class SetGameObjectVariableValue : SetVariableValue<
        GameObject,
        GameObjectVariable,
        GameObjectReference,
        GameObjectEvent,
        GameObjectGameObjectEvent>
    { }
}
