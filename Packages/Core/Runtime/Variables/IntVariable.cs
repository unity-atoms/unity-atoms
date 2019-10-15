using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `int`. Inherits from `EquatableAtomVariable&lt;int, IntEvent, IntIntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
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
