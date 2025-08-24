using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;float&gt;`. Inherits from `IPair&lt;float&gt;`.
    /// </summary>
    [Serializable]
    public struct FloatPair : IPair<float>
    {
        public float Value { get => _item1; set => _item1 = value; }
        public float OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private float _item1;
        [SerializeField]
        private float _item2;

        public void Deconstruct(out float item1, out float item2) { item1 = Value; item2 = OldValue; }
    }
}