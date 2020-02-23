using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event x 2 Reference of type `GameObject`. Inherits from `AtomEventX2Reference&lt;GameObject, GameObjectVariable, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction, GameObjectVariableInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectGameObjectEventReference : AtomEventX2Reference<
        GameObject,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectGameObjectEvent,
        GameObjectGameObjectFunction,
        GameObjectVariableInstancer> { }
}
