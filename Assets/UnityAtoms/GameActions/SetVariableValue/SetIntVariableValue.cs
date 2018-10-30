using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Game Actions/Set Variable Value/Int")]
    public class SetIntVariableValue : SetVariableValue<int, IntVariable, IntReference, IntEvent, IntIntEvent> { }
}