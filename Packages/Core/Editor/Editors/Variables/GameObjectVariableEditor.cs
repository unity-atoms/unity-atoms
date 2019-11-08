using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(GameObjectVariable))]
    public class GameObjectVariableEditor : AtomVariableEditor<GameObject>
    {
    }
}
