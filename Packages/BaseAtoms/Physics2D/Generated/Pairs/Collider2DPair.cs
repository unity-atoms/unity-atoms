using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collider2D&gt;`. Inherits from `IPair&lt;UnityEngine.Collider2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Collider2DPair : IPair<UnityEngine.Collider2D>
    {
        public UnityEngine.Collider2D Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.Collider2D Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.Collider2D _item1;
        [SerializeField]
        private UnityEngine.Collider2D _item2;

        public void Deconstruct(out UnityEngine.Collider2D item1, out UnityEngine.Collider2D item2) { item1 = Item1; item2 = Item2; }
    }
}