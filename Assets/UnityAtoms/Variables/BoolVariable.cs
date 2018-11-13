using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Bool")]
    public class BoolVariable : EquatableScriptableObjectVariable<bool, BoolEvent, BoolBoolEvent> { }
}