using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Collision&gt;`. Inherits from `IPair&lt;Collision&gt;`.
    /// </summary>
    [Serializable]
    public struct CollisionPair : IPair<Collision>
    {
        public Collision Value { get => _item1; set => _item1 = value; }
        public Collision OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Collision _item1;
        [SerializeField]
        private Collision _item2;

        public void Deconstruct(out Collision item1, out Collision item2) { item1 = Value; item2 = OldValue; }
    }
}