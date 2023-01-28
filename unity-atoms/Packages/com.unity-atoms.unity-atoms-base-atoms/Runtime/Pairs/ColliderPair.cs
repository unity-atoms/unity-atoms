using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Collider&gt;`. Inherits from `IPair&lt;Collider&gt;`.
    /// </summary>
    [Serializable]
    public struct ColliderPair : IPair<Collider>
    {
        public Collider Item1 { get => _item1; set => _item1 = value; }
        public Collider Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Collider _item1;
        [SerializeField]
        private Collider _item2;

        public void Deconstruct(out Collider item1, out Collider item2) { item1 = Item1; item2 = Item2; }
    }
}