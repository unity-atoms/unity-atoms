using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Collider`. Inherits from `AtomVariableInstancer&lt;ColliderVariable, Collider, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Collider Instancer")]
    public class ColliderVariableInstancer : AtomVariableInstancer<ColliderVariable, Collider, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction> { }
}
