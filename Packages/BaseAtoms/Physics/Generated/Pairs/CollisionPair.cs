using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Collision&gt;`. Inherits from `IPair&lt;UnityEngine.Collision&gt;`.
    /// </summary>
    [Serializable]
    public struct CollisionPair : IPair<UnityEngine.Collision>
    {
        public UnityEngine.Collision Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.Collision Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.Collision _item1;
        [SerializeField]
        private UnityEngine.Collision _item2;

        public void Deconstruct(out UnityEngine.Collision item1, out UnityEngine.Collision item2) { item1 = Item1; item2 = Item2; }
    }
}