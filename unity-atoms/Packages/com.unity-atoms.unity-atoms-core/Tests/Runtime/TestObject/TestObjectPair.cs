using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    [Serializable]
    public struct TestObjectPair : IPair<TestObject>
    {
        public TestObject Item1 { get => _item1; set => _item1 = value; }
        public TestObject Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private TestObject _item1;
        [SerializeField]
        private TestObject _item2;

        public void Deconstruct(out TestObject item1, out TestObject item2) { item1 = Item1; item2 = Item2; }
    }
}