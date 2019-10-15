using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `GameObject`. Inherits from `SetVariableValue&lt;GameObject, GameObjectVariable, GameObjectReference, GameObjectEvent, GameObjectGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/GameObject", fileName = "SetGameObjectVariableValue")]
    public sealed class SetGameObjectVariableValue : SetVariableValue<
        GameObject,
        GameObjectVariable,
        GameObjectReference,
        GameObjectEvent,
        GameObjectGameObjectEvent>
    { }
}
