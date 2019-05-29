using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collider2D", fileName = "Collider2DList")]
    public sealed class Collider2DList : ScriptableObjectList<Collider2D, Collider2DEvent> { }
}
