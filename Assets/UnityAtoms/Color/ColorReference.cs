using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class ColorReference : ScriptableObjectReference<Color, ColorVariable, ColorEvent, ColorColorEvent> { }
}