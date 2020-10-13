using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Condition of type `Collider`. Inherits from `AtomCondition&lt;Collider&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    public abstract class ColliderCondition : AtomCondition<Collider> { }
}