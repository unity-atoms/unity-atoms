using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `Collision2D`. Inherits from `AtomEventReference&lt;Collision2D, Collision2DVariable, Collision2DEvent, Collision2DVariableInstancer, Collision2DEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collision2DEventReference : AtomEventReference<
        Collision2D,
        Collision2DVariable,
        Collision2DEvent,
        Collision2DVariableInstancer,
        Collision2DEventInstancer>, IGetEvent 
    { }
}
