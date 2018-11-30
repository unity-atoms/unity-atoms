using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class StringReference : ScriptableObjectReference<string, StringVariable, StringEvent, StringStringEvent> { }
}