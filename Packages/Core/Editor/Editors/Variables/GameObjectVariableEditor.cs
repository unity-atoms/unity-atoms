using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(GameObjectVariable))]
    public class GameObjectVariableEditor : AtomVariableEditor<GameObject>
    {
        protected override GameObject Field(string label, GameObject value) => SerializedPropertyExtensions.ValueLayoutField(label, value);
    }
}
