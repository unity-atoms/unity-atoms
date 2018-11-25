using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Game Actions/Set Variable Value/GameObject",
        fileName              = "SetGameObjectVariableValueAction", order = 6)]
    public class SetGameObjectVariableValue : SetVariableValue<GameObject, GameObjectVariable, GameObjectReference,
        GameObjectEvent, GameObjectGameObjectEvent>
    {
    }
}