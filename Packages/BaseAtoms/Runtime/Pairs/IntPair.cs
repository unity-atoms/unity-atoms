using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;int&gt;`. Inherits from `IPair&lt;int&gt;`.
    /// </summary>
    [Serializable]
    public struct IntPair : IPair<int>
    {
        public int Value { get => _item1; set => _item1 = value; }
        public int OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private int _item1;
        [SerializeField]
        private int _item2;

        public void Deconstruct(out int item1, out int item2) { item1 = Value; item2 = OldValue; }
    }
}