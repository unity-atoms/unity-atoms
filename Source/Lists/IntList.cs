using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Int", fileName = "IntList")]
    public sealed class IntList : ScriptableObjectList<int, IntEvent> { }
}
