using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `GameObject`. Inherits from `AtomEventReference&lt;GameObject, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectEventReference : AtomEventReference<
        GameObject,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectGameObjectEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer> { }
}
