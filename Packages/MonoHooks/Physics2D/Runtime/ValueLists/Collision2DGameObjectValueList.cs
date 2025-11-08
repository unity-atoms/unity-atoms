using UnityEngine;
using UnityAtoms.MonoHooks;

namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// Value List of type `Collision2DGameObject`. Inherits from `AtomValueList&lt;Collision2DGameObject, Collision2DGameObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Collision2DGameObject", fileName = "Collision2DGameObjectValueList")]
    public sealed class Collision2DGameObjectValueList : AtomValueList<Collision2DGameObject, Collision2DGameObjectEvent> { }
}
