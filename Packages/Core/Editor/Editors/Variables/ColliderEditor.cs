using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(ColliderVariable))]
    public class ColliderEditor : AtomVariableEditor<Collider>
    {
    }
}
