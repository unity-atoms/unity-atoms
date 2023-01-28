using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `GameObject`. Inherits from `AtomVariableInstancer&lt;GameObjectVariable, GameObjectPair, GameObject, GameObjectEvent, GameObjectPairEvent, GameObjectGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/GameObject Variable Instancer")]
    public class GameObjectVariableInstancer : AtomVariableInstancer<
        GameObjectVariable,
        GameObjectPair,
        GameObject,
        GameObjectEvent,
        GameObjectPairEvent,
        GameObjectGameObjectFunction>
    { }
}
