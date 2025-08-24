using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Vector2&gt;`. Inherits from `IPair&lt;Vector2&gt;`.
    /// </summary>
    [Serializable]
    public struct Vector2Pair : IPair<Vector2>
    {
        public Vector2 Value { get => _item1; set => _item1 = value; }
        public Vector2 OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Vector2 _item1;
        [SerializeField]
        private Vector2 _item2;

        public void Deconstruct(out Vector2 item1, out Vector2 item2) { item1 = Value; item2 = OldValue; }
    }
}