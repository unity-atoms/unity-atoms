using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Vector2", fileName = "Vector2List", order = 4)]
    public class Vector2List : ScriptableObjectList<Vector2, Vector2Event>
    {
    }
}