using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable of type `Collider2DGameObject`. Inherits from `EquatableAtomVariable&lt;Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collider2DGameObject", fileName = "Collider2DGameObjectVariable")]
    public sealed class Collider2DGameObjectVariable : EquatableAtomVariable<Collider2DGameObject, Collider2DGameObjectPair, Collider2DGameObjectEvent, Collider2DGameObjectPairEvent, Collider2DGameObjectCollider2DGameObjectFunction> { }
}
