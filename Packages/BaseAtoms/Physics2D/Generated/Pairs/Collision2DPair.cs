using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collision2D&gt;`. Inherits from `IPair&lt;UnityEngine.Collision2D&gt;`.
    /// </summary>
    [Serializable]
    public struct Collision2DPair : IPair<UnityEngine.Collision2D>
    {
        public UnityEngine.Collision2D Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.Collision2D Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.Collision2D _item1;
        [SerializeField]
        private UnityEngine.Collision2D _item2;

        public void Deconstruct(out UnityEngine.Collision2D item1, out UnityEngine.Collision2D item2) { item1 = Item1; item2 = Item2; }
    }
}