using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Value List of type `Collider2DGameObject`. Inherits from `AtomValueList&lt;Collider2DGameObject, Collider2DGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Collider2DGameObject", fileName = "Collider2DGameObjectValueList")]
    public sealed class Collider2DGameObjectValueList : AtomValueList<Collider2DGameObject, Collider2DGameObjectEvent> { }
}
