using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Bool", fileName = "BoolList", order = 2)]
    public class BoolList : ScriptableObjectList<bool, BoolEvent>
    {
    }
}