#if UNITY_2019_1_OR_NEWER
using UnityEditor;

namespace UnityAtoms.Editor
{
    [CustomPropertyDrawer(typeof(GameObjectGameObjectEvent))]
    public class GameObjectGameObjectEventDrawer : AtomDrawer<GameObjectGameObjectEvent> { }
}
#endif
