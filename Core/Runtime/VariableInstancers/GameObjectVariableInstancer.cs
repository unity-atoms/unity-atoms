using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `GameObject`. Inherits from `AtomVariableInstancer&lt;GameObjectVariable, GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    public class GameObjectVariableInstancer : AtomVariableInstancer<GameObjectVariable, GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction> { }
}
