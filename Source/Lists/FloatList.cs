using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Lists/Float", fileName = "FloatList")]
    public sealed class FloatList : ScriptableObjectList<float, FloatEvent> { }
}
