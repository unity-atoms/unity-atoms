using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Collider`. Inherits from `AtomVariableInstancer&lt;ColliderVariable, Collider, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    public class ColliderVariableInstancer : AtomVariableInstancer<ColliderVariable, Collider, ColliderEvent, ColliderColliderEvent, ColliderColliderFunction> { }
}
