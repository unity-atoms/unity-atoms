using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider2D", fileName = "Collider2DList", order = 6)]
    public class Collider2DList : ScriptableObjectList<Collider2D, Collider2DEvent>
    {
    }
}