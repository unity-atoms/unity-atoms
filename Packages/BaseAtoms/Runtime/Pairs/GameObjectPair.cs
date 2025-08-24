using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;GameObject&gt;`. Inherits from `IPair&lt;GameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct GameObjectPair : IPair<GameObject>
    {
        public GameObject Value { get => _item1; set => _item1 = value; }
        public GameObject OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private GameObject _item1;
        [SerializeField]
        private GameObject _item2;

        public void Deconstruct(out GameObject item1, out GameObject item2) { item1 = Value; item2 = OldValue; }
    }
}