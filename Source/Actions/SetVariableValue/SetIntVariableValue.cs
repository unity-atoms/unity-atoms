using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable/Int", fileName = "SetIntVariableValueAction")]
    public sealed class SetIntVariableValue : SetVariableValue<
        int,
        IntVariable,
        IntReference,
        IntEvent,
        IntIntEvent>
    { }
}
