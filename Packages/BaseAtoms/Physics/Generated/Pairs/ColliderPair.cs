using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collider&gt;`. Inherits from `IPair&lt;UnityEngine.Collider&gt;`.
    /// </summary>
    [Serializable]
    public struct ColliderPair : IPair<UnityEngine.Collider>
    {
        public UnityEngine.Collider Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.Collider Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.Collider _item1;
        [SerializeField]
        private UnityEngine.Collider _item2;

        public void Deconstruct(out UnityEngine.Collider item1, out UnityEngine.Collider item2) { item1 = Item1; item2 = Item2; }
    }
}