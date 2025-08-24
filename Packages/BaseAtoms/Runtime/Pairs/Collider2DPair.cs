using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Collider2D&gt;`. Inherits from `IPair&lt;Collider2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Collider2DPair : IPair<Collider2D>
    {
        public Collider2D Value { get => _item1; set => _item1 = value; }
        public Collider2D OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Collider2D _item1;
        [SerializeField]
        private Collider2D _item2;

        public void Deconstruct(out Collider2D item1, out Collider2D item2) { item1 = Value; item2 = OldValue; }
    }
}