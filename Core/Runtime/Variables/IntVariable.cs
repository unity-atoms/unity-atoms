using UnityEngine;

namespace UnityAtoms
{
    [UseIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Int", fileName = "IntVariable")]
    public sealed class IntVariable : EquatableAtomVariable<int, IntEvent, IntIntEvent>, IWithApplyChange<int, IntEvent, IntIntEvent>
    {
        public bool ApplyChange(int amount)
        {
            return SetValue(Value + amount);
        }

        public bool ApplyChange(EquatableAtomVariable<int, IntEvent, IntIntEvent> amount)
        {
            return SetValue(Value + amount.Value);
        }
    }
}
