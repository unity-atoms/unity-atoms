using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Vector2`. Inherits from `AtomEventReference&lt;Vector2, Vector2Variable, Vector2Event, Vector2VariableInstancer, Vector2EventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2EventReference : AtomEventReference<
        Vector2,
        Vector2Variable,
        Vector2Event,
        Vector2VariableInstancer,
        Vector2EventInstancer>, IGetEvent 
    { }
}
