using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `Collision2D`. Inherits from `EquatableAtomVariable&lt;Collision2D, Collision2DPair, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collision2D", fileName = "Collision2DVariable")]
    public sealed class Collision2DVariable : EquatableAtomVariable<Collision2D, Collision2DPair, Collision2DEvent, Collision2DPairEvent, Collision2DCollision2DFunction> { }
}
