using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Collider2D`. Inherits from `AtomVariableInstancer&lt;Collider2DVariable, Collider2DPair, Collider2D, Collider2DEvent, Collider2DPairEvent, Collider2DCollider2DFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collider2D Variable Instancer")]
    public class Collider2DVariableInstancer : AtomVariableInstancer<
        Collider2DVariable,
        Collider2DPair,
        Collider2D,
        Collider2DEvent,
        Collider2DPairEvent,
        Collider2DCollider2DFunction>
    { }
}
