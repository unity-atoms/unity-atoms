using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector2", fileName = "Vector2List")]
    public sealed class Vector2List : AtomList<Vector2, Vector2Event> { }
}
