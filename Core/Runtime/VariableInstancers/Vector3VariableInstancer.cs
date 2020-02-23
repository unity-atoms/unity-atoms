using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Vector3`. Inherits from `AtomVariableInstancer&lt;Vector3Variable, Vector3, Vector3Event, Vector3Vector3Event, Vector3Vector3Function&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Vector3 Instancer")]
    public class Vector3VariableInstancer : AtomVariableInstancer<Vector3Variable, Vector3, Vector3Event, Vector3Vector3Event, Vector3Vector3Function> { }
}
