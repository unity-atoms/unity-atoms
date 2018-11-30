using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Color/Variable", fileName = "ColorVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class ColorVariable : ScriptableObjectVariable<Color, ColorEvent, ColorColorEvent>
    {
        protected override bool AreEqual(Color first, Color second)
        {
            return first.Equals(second);
        }
    }
}