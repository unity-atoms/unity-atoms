using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/Float List")]
    public class FloatList : ScriptableObjectList<float>
    {
        public FloatEvent Added;
        protected override GameEvent<float> _Added { get { return Added; } }

        public FloatEvent Removed;
        protected override GameEvent<float> _Removed { get { return Removed; } }
    }
}