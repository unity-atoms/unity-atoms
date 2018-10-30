using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/Vector3 List")]
    public class Vector3List : ScriptableObjectList<Vector3>
    {
        public Vector3Event Added;
        protected override GameEvent<Vector3> _Added { get { return Added; } }

        public Vector3Event Removed;
        protected override GameEvent<Vector3> _Removed { get { return Removed; } }
    }
}