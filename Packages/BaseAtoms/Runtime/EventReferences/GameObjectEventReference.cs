using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `GameObject`. Inherits from `AtomEventReference&lt;GameObject, GameObjectVariable, GameObjectEvent, GameObjectVariableInstancer, GameObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectEventReference : AtomEventReference<
        GameObject,
        GameObjectVariable,
        GameObjectEvent,
        GameObjectVariableInstancer,
        GameObjectEventInstancer>, IGetEvent 
    { }
}
