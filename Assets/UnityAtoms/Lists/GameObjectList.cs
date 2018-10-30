using System;
using UnityEngine;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "UnityAtoms/Lists/GameObject List")]
    public class GameObjectList : ScriptableObjectList<GameObject>
    {
        public GameObjectEvent Added;
        protected override GameEvent<GameObject> _Added { get { return Added; } }

        public GameObjectEvent Removed;
        protected override GameEvent<GameObject> _Removed { get { return Removed; } }
    }
}