using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;bool&gt;`. Inherits from `IPair&lt;bool&gt;`.
    /// </summary>
    [Serializable]
    public struct BoolPair : IPair<bool>
    {
        public bool Value { get => _item1; set => _item1 = value; }
        public bool OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private bool _item1;
        [SerializeField]
        private bool _item2;

        public void Deconstruct(out bool item1, out bool item2) { item1 = Value; item2 = OldValue; }
    }
}