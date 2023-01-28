using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Vector3&gt;`. Inherits from `IPair&lt;Vector3&gt;`.
    /// </summary>
    [Serializable]
    public struct Vector3Pair : IPair<Vector3>
    {
        public Vector3 Item1 { get => _item1; set => _item1 = value; }
        public Vector3 Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Vector3 _item1;
        [SerializeField]
        private Vector3 _item2;

        public void Deconstruct(out Vector3 item1, out Vector3 item2) { item1 = Item1; item2 = Item2; }
    }
}