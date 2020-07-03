#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collision`. Inherits from `AtomDrawer&lt;CollisionVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer (typeof (CollisionVariable))]
    public class CollisionVariableDrawer : VariableDrawer<CollisionVariable> { }
}
#endif