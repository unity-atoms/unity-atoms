using System;
using UnityEngine;
using UnityAtoms.MonoHooks;
namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// IPair of type `&lt;Collision2DGameObject&gt;`. Inherits from `IPair&lt;Collision2DGameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct Collision2DGameObjectPair : IPair<Collision2DGameObject>
    {
        public Collision2DGameObject Value { get => _item1; set => _item1 = value; }
        public Collision2DGameObject OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Collision2DGameObject _item1;
        [SerializeField]
        private Collision2DGameObject _item2;

        public void Deconstruct(out Collision2DGameObject item1, out Collision2DGameObject item2) { item1 = Value; item2 = OldValue; }
    }
}