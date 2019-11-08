using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor{
    [CustomEditor(typeof(Vector3Variable))]
    public class Vector3VariableEditor : AtomVariableEditor<Vector3>
    {
    }
}
