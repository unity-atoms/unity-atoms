using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;double&gt;`. Inherits from `IPair&lt;double&gt;`.
    /// </summary>
    [Serializable]
    public struct DoublePair : IPair<double>
    {
        public double Value { get => _item1; set => _item1 = value; }
        public double OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private double _item1;
        [SerializeField]
        private double _item2;

        public void Deconstruct(out double item1, out double item2) { item1 = Value; item2 = OldValue; }
    }
}