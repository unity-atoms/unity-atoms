using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `GameObject`. Inherits from `SetVariableValue&lt;GameObject, GameObjectPair, GameObjectVariable, GameObjectConstant, GameObjectReference, GameObjectEvent, GameObjectPairEvent, GameObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/GameObject", fileName = "SetGameObjectVariableValue")]
    public sealed class SetGameObjectVariableValue : SetVariableValue<
        GameObject,
        GameObjectPair,
        GameObjectVariable,
        GameObjectConstant,
        GameObjectReference,
        GameObjectEvent,
        GameObjectPairEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer>
    { }
}
