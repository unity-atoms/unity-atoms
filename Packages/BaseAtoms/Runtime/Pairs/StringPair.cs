using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;string&gt;`. Inherits from `IPair&lt;string&gt;`.
    /// </summary>
    [Serializable]
    public struct StringPair : IPair<string>
    {
        public string Value { get => _item1; set => _item1 = value; }
        public string OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private string _item1;
        [SerializeField]
        private string _item2;

        public void Deconstruct(out string item1, out string item2) { item1 = Value; item2 = OldValue; }
    }
}