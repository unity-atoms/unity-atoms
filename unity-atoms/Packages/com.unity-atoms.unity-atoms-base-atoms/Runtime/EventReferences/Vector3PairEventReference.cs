using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Vector3Pair`. Inherits from `AtomEventReference&lt;Vector3Pair, Vector3Variable, Vector3PairEvent, Vector3VariableInstancer, Vector3PairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector3PairEventReference : AtomEventReference<
        Vector3Pair,
        Vector3Variable,
        Vector3PairEvent,
        Vector3VariableInstancer,
        Vector3PairEventInstancer>, IGetEvent 
    { }
}
