using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `GameObject`. Inherits from `AtomReference&lt;GameObject, GameObjectConstant, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectReference : AtomReference<
        GameObject,
        GameObjectConstant,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectGameObjectEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer> { }
}
