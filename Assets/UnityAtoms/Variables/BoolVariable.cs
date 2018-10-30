using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Variables/Bool")]
    public class BoolVariable : EquatableScriptableObjectVariable<bool, BoolEvent, BoolBoolEvent> { }
}