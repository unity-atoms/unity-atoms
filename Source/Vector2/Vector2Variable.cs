using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Vector2/Variable", fileName = "Vector2Variable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class Vector2Variable : ScriptableObjectVariable<Vector2, Vector2Event, Vector2Vector2Event>
    {
        protected override bool AreEqual(Vector2 first, Vector2 second)
        {
            return first.Equals(second);
        }
    }
}