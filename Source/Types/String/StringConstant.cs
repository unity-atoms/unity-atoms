using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/String/Constant", fileName = "StringConstant", order = CreateAssetMenuUtils.Order.CONSTANT)]
    public sealed class StringConstant : ScriptableObjectVariableBase<string> { }
}
