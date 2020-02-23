using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `GameObject`. Inherits from `AtomVariableInstancer&lt;GameObjectVariable, GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/GameObject Instancer")]
    public class GameObjectVariableInstancer : AtomVariableInstancer<GameObjectVariable, GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction> { }
}
