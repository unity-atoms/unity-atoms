using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// List of type `Vector2`. Inherits from `AtomList&lt;Vector2, Vector2Event&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector2", fileName = "Vector2List")]
    public sealed class Vector2List : AtomList<Vector2, Vector2Event> { }
}
