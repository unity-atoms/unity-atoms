#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(GameObjectList))]
    public class GameObjectListDrawer : AtomDrawer<GameObjectList> { }
}
#endif
