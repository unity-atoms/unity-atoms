using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector2", fileName = "Vector2List")]
    public sealed class Vector2List : ScriptableObjectList<Vector2, Vector2Event> { }
}
