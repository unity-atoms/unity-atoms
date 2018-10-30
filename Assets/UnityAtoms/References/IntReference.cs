using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class IntReference : ScriptableObjectReference<int, IntVariable, IntEvent, IntIntEvent> { }
}