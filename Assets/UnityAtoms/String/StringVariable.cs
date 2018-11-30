using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/String/Variable", fileName = "StringVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class StringVariable : EquatableScriptableObjectVariable<string, StringEvent, StringStringEvent> { }
}