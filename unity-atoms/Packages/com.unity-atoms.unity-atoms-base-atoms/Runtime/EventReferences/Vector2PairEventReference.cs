using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Vector2Pair`. Inherits from `AtomEventReference&lt;Vector2Pair, Vector2Variable, Vector2PairEvent, Vector2VariableInstancer, Vector2PairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2PairEventReference : AtomEventReference<
        Vector2Pair,
        Vector2Variable,
        Vector2PairEvent,
        Vector2VariableInstancer,
        Vector2PairEventInstancer>, IGetEvent 
    { }
}
