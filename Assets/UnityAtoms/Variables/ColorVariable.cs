using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Variables/Color")]
    public class ColorVariable : EquatableScriptableObjectVariable<Color, ColorEvent, ColorColorEvent> { }
}