using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `Vector2`. Inherits from `AtomValueList&lt;Vector2, Vector2Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Vector2", fileName = "Vector2ValueList")]
    public sealed class Vector2ValueList : AtomValueList<Vector2, Vector2Event> { }
}
