using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/GameObject", fileName = "SetGameObjectVariableValue")]
    public sealed class SetGameObjectVariableValue : SetVariableValue<
        GameObject,
        GameObjectVariable,
        GameObjectReference,
        GameObjectEvent,
        GameObjectGameObjectEvent>
    { }
}
