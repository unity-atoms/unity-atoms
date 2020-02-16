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
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return (first == null && second == null) || first != null && second != null && first.GetInstanceID() == second.GetInstanceID();
        }
    }
}
