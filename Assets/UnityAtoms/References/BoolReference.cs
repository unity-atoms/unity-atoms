using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class BoolReference : ScriptableObjectReference<bool, BoolVariable, BoolEvent, BoolBoolEvent> { }
}