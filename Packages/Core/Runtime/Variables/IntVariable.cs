using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `int`. Inherits from `EquatableAtomVariable&lt;int, IntEvent, IntIntEvent, IntIntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Int", fileName = "IntVariable")]
    public sealed class IntVariable : EquatableAtomVariable<int, IntEvent, IntIntEvent, IntIntFunction>
    {
        public bool ApplyChange(int amount)
        {
            return SetValue(Value + amount);
        }

        public bool ApplyChange(EquatableAtomVariable<int, IntEvent, IntIntEvent, IntIntFunction> amount)
        {
            return SetValue(Value + amount.Value);
        }
    }
}
