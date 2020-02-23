using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `GameObject`. Inherits from `AtomVariable&lt;GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObject", fileName = "GameObjectVariable")]
    public sealed class GameObjectVariable : AtomVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent, GameObjectGameObjectFunction>
    {
        protected override bool ValueEquals(GameObject other)
        {
            return (_value == null && other == null) || _value != null && other != null && _value.GetInstanceID() == other.GetInstanceID();
        }
    }
}
