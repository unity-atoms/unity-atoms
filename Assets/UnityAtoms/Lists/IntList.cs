using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Int", fileName = "IntList", order = 0)]
    public class IntList : ScriptableObjectList<int, IntEvent>
    {
    }
}