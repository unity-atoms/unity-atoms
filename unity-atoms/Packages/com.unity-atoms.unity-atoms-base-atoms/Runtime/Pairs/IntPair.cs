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
        public int Item1 { get => _item1; set => _item1 = value; }
        public int Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private int _item1;
        [SerializeField]
        private int _item2;

        public void Deconstruct(out int item1, out int item2) { item1 = Item1; item2 = Item2; }
    }
}