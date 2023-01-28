using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Variable of type `Collision2DGameObject`. Inherits from `EquatableAtomVariable&lt;Collision2DGameObject, Collision2DGameObjectPair, Collision2DGameObjectEvent, Collision2DGameObjectPairEvent, Collision2DGameObjectCollision2DGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Collision2DGameObject", fileName = "Collision2DGameObjectVariable")]
    public sealed class Collision2DGameObjectVariable : EquatableAtomVariable<Collision2DGameObject, Collision2DGameObjectPair, Collision2DGameObjectEvent, Collision2DGameObjectPairEvent, Collision2DGameObjectCollision2DGameObjectFunction>
    {
    }
}
