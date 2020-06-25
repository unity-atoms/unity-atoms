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
        public GameObject Item1 { get => _item1; set => _item1 = value; }
        public GameObject Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private GameObject _item1;
        [SerializeField]
        private GameObject _item2;

        public void Deconstruct(out GameObject item1, out GameObject item2) { item1 = Item1; item2 = Item2; }
    }
}