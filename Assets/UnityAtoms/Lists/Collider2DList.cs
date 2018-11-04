using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/Collider2D")]
    public class Collider2DList : ScriptableObjectList<Collider2D, Collider2DEvent> { }
}