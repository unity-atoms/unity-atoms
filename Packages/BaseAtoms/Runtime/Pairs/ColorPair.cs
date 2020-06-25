using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;Color&gt;`. Inherits from `IPair&lt;Color&gt;`.
    /// </summary>
    [Serializable]
    public struct ColorPair : IPair<Color>
    {
        public Color Item1 { get => _item1; set => _item1 = value; }
        public Color Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Color _item1;
        [SerializeField]
        private Color _item2;

        public void Deconstruct(out Color item1, out Color item2) { item1 = Item1; item2 = Item2; }
    }
}