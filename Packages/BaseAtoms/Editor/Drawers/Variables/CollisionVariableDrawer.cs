#if UNITY_2019_1_OR_NEWER && PACKAGE_UNITY_PHYSICS
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Collision`. Inherits from `AtomDrawer&lt;CollisionVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(CollisionVariable))]
    public class CollisionVariableDrawer : VariableDrawer<CollisionVariable> { }
}
#endif
