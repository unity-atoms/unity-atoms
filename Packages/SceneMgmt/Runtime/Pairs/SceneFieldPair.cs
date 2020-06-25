using System;
using UnityEngine;
using UnityAtoms.SceneMgmt;
namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// IPair of type `&lt;SceneField&gt;`. Inherits from `IPair&lt;SceneField&gt;`.
    /// </summary>
    [Serializable]
    public struct SceneFieldPair : IPair<SceneField>
    {
        public SceneField Item1 { get => _item1; set => _item1 = value; }
        public SceneField Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private SceneField _item1;
        [SerializeField]
        private SceneField _item2;

        public void Deconstruct(out SceneField item1, out SceneField item2) { item1 = Item1; item2 = Item2; }
    }
}