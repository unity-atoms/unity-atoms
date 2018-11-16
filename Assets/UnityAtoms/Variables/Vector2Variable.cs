using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector2")]
    public class Vector2Variable : ScriptableObjectVariable<Vector2, Vector2Event, Vector2Vector2Event>
    {
        protected override bool AreEqual(Vector2 first, Vector2 second)
        {
            return first.Equals(second);
        }
    }
}