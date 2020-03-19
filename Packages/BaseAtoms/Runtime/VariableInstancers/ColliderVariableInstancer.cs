using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `Collider`. Inherits from `AtomVariableInstancer&lt;ColliderVariable, ColliderPair, Collider, ColliderEvent, ColliderPairEvent, ColliderColliderFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collider Variable Instancer")]
    public class ColliderVariableInstancer : AtomVariableInstancer<
        ColliderVariable,
        ColliderPair,
        Collider,
        ColliderEvent,
        ColliderPairEvent,
        ColliderColliderFunction>
    { }
}
