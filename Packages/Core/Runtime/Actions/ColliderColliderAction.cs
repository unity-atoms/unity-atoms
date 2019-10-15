using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// Action x 2 of type `Collider`. Inherits from `AtomAction&lt;Collider, Collider&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    public abstract class ColliderColliderAction : AtomAction<Collider, Collider> { }
}
