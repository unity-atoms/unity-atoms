using System;
using UnityEngine;
using UnityAtoms.MonoHooks;
namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// IPair of type `&lt;Collider2DGameObject&gt;`. Inherits from `IPair&lt;Collider2DGameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct Collider2DGameObjectPair : IPair<Collider2DGameObject>
    {
        public Collider2DGameObject Value { get => _item1; set => _item1 = value; }
        public Collider2DGameObject OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Collider2DGameObject _item1;
        [SerializeField]
        private Collider2DGameObject _item2;

        public void Deconstruct(out Collider2DGameObject item1, out Collider2DGameObject item2) { item1 = Value; item2 = OldValue; }
    }
}