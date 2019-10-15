using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Vector2`. Inherits from `EquatableAtomVariable&lt;Vector2, Vector2Event, Vector2Vector2Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector2", fileName = "Vector2Variable")]
    public sealed class Vector2Variable : EquatableAtomVariable<Vector2, Vector2Event, Vector2Vector2Event> { }
}
