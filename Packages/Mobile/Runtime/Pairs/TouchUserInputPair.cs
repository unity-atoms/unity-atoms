using System;
using UnityEngine;
using UnityAtoms.Mobile;
namespace UnityAtoms.Mobile
{
    /// <summary>
    /// IPair of type `&lt;TouchUserInput&gt;`. Inherits from `IPair&lt;TouchUserInput&gt;`.
    /// </summary>
    [Serializable]
    public struct TouchUserInputPair : IPair<TouchUserInput>
    {
        public TouchUserInput Item1 { get => _item1; set => _item1 = value; }
        public TouchUserInput Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private TouchUserInput _item1;
        [SerializeField]
        private TouchUserInput _item2;

        public void Deconstruct(out TouchUserInput item1, out TouchUserInput item2) { item1 = Item1; item2 = Item2; }
    }
}