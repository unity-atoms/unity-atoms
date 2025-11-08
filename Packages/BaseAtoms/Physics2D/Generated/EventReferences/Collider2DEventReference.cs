using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityEngine.Collider2D`. Inherits from `AtomEventReference&lt;UnityEngine.Collider2D, Collider2DVariable, Collider2DEvent, Collider2DVariableInstancer, Collider2DEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Collider2DEventReference : AtomEventReference<
        UnityEngine.Collider2D,
        Collider2DVariable,
        Collider2DEvent,
        Collider2DVariableInstancer,
        Collider2DEventInstancer>, IGetEvent 
    { }
}
