using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Bool")]
    public class BoolList : ScriptableObjectList<bool, BoolEvent> { }
}