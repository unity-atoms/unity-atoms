using System;
using UnityEngine;
using UnityAtoms.MonoHooks;
namespace UnityAtoms.MonoHooks
{
    /// <summary>
    /// IPair of type `&lt;ColliderGameObject&gt;`. Inherits from `IPair&lt;ColliderGameObject&gt;`.
    /// </summary>
    [Serializable]
    public struct ColliderGameObjectPair : IPair<ColliderGameObject>
    {
        public ColliderGameObject Value { get => _item1; set => _item1 = value; }
        public ColliderGameObject OldValue { get => _item2; set => _item2 = value; }

        [SerializeField]
        private ColliderGameObject _item1;
        [SerializeField]
        private ColliderGameObject _item2;

        public void Deconstruct(out ColliderGameObject item1, out ColliderGameObject item2) { item1 = Value; item2 = OldValue; }
    }
}