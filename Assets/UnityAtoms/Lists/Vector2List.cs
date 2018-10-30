using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/Vector2 List")]
    public class Vector2List : ScriptableObjectList<Vector2>
    {
        public Vector2Event Added;
        protected override GameEvent<Vector2> _Added { get { return Added; } }

        public Vector2Event Removed;
        protected override GameEvent<Vector2> _Removed { get { return Removed; } }
    }
}