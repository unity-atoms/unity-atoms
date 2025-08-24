using System;
using UnityEngine;
using UnityAtoms.MonoHooks;
namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// IPair of type `&lt;CollisionGameObject&gt;`. Inherits from `IPair&lt;CollisionGameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct CollisionGameObjectPair : IPair<CollisionGameObject>
    {
        public CollisionGameObject Value { get => _item1; set => _item1 = value; }
        public CollisionGameObject OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private CollisionGameObject _item1;
        [SerializeField]
        private CollisionGameObject _item2;

        public void Deconstruct(out CollisionGameObject item1, out CollisionGameObject item2) { item1 = Value; item2 = OldValue; }
    }
}