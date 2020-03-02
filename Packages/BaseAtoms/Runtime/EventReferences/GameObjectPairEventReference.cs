using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `GameObjectPair`. Inherits from `AtomEventReference&lt;GameObjectPair, GameObjectVariable, GameObjectPairEvent, GameObjectVariableInstancer, GameObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class GameObjectPairEventReference : AtomEventReference<
        GameObjectPair,
        GameObjectVariable,
        GameObjectPairEvent,
        GameObjectVariableInstancer,
        GameObjectPairEventInstancer>, IGetEvent 
    { }
}
