using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Collision2D&gt;`. Inherits from `IPair&lt;Collision2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Collision2DPair : IPair<Collision2D>
    {
        public Collision2D Item1 { get => _item1; set => _item1 = value; }
        public Collision2D Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Collision2D _item1;
        [SerializeField]
        private Collision2D _item2;

        public void Deconstruct(out Collision2D item1, out Collision2D item2) { item1 = Item1; item2 = Item2; }
    }
}