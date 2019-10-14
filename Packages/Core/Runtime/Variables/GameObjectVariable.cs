using System;
using UnityEngine;

namespace UnityAtoms
{
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/GameObject", fileName = "GameObjectVariable")]
    public sealed class GameObjectVariable : AtomVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>
    {
        protected override bool AreEqual(GameObject first, GameObject second)
        {
            return (first == null && second == null) || first != null && second != null && first.GetInstanceID() == second.GetInstanceID();
        }
    }
}
