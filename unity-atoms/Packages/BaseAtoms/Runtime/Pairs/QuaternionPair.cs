using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Quaternion&gt;`. Inherits from `IPair&lt;Quaternion&gt;`.
    /// </summary>
    [Serializable]
    public struct QuaternionPair : IPair<Quaternion>
    {
        public Quaternion Item1 { get => _item1; set => _item1 = value; }
        public Quaternion Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Quaternion _item1;
        [SerializeField]
        private Quaternion _item2;

        public void Deconstruct(out Quaternion item1, out Quaternion item2) { item1 = Item1; item2 = Item2; }
    }
}