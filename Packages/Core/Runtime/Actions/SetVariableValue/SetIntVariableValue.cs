using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Int", fileName = "SetIntVariableValue")]
    public sealed class SetIntVariableValue : SetVariableValue<
        int,
        IntVariable,
        IntReference,
        IntEvent,
        IntIntEvent>
    { }
}
