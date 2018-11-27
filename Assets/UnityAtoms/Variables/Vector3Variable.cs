using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector3", fileName = "Vector3Variable", order = 5)]
    public class Vector3Variable : ScriptableObjectVariable<Vector3, Vector3Event, Vector3Vector3Event>
    {
        protected override bool AreEqual(Vector3 first, Vector3 second)
        {
            return first.Equals(second);
        }
    }
}