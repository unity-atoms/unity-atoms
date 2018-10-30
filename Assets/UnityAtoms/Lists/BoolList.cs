using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/Bool List")]
    public class BoolList : ScriptableObjectList<bool>
    {
        public BoolEvent Added;
        protected override GameEvent<bool> _Added { get { return Added; } }

        public BoolEvent Removed;
        protected override GameEvent<bool> _Removed { get { return Removed; } }
    }
}