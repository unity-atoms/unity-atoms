using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider2D")]
    public class Collider2DList : ScriptableObjectList<Collider2D, Collider2DEvent> { }
}