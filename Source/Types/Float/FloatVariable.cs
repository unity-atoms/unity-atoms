using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Float/Variable", fileName = "FloatVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public sealed class FloatVariable : EquatableScriptableObjectVariable<float, FloatEvent, FloatFloatEvent>
    {
    }
}
