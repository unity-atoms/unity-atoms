using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Color/Event x 2", fileName = "ColorColorEvent", order = CreateAssetMenuUtils.Order.EVENTx2)]
    public sealed class ColorColorEvent : GameEvent<Color, Color> { }
}
