using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Collision2D", fileName = "Collision2DList")]
    public sealed class Collision2DList : AtomList<Collision2D, Collision2DEvent> { }
}
