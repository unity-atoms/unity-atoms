using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Color")]
    public class ColorVariable : EquatableScriptableObjectVariable<Color, ColorEvent, ColorColorEvent> { }
}