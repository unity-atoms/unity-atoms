using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Float", fileName = "FloatList", order = 1)]
    public class FloatList : ScriptableObjectList<float, FloatEvent>
    {
    }
}