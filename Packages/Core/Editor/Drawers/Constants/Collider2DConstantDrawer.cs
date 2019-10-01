#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(Collider2DConstant))]
    public class Collider2DConstantDrawer : AtomDrawer<Collider2DConstant> { }
}
#endif
