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
        public double Item1 { get => _item1; set => _item1 = value; }
        public double Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private double _item1;
        [SerializeField]
        private double _item2;

        public void Deconstruct(out double item1, out double item2) { item1 = Item1; item2 = Item2; }
    }
}