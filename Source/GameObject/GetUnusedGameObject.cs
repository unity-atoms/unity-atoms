using UnityEngine;
using UnityAtoms.Extensions;
#if UNITY_EDITOR
using UnityAtoms.Logger;
#endif

namespace UnityAtoms
{
    /* Gets an unused GameObject from the GameObjectList. If an GameObject is used or not is determined by IsUsed GameFunction.
	 * If no unused GameObject is found a new one is instantiated and added to the GameObjectList.
	 */
    [CreateAssetMenu(menuName = "Unity Atoms/GameObject/Get Unused GameObject (GameObject - (V3, Quat))", fileName = "GetUnusedGameObject")]
    public class GetUnusedGameObject : GameObjectVector3QuaternionFunction
    {
        [SerializeField]
        private GameObjectList List = null;

        [SerializeField]
        private GameObject Prefab = null;

        [SerializeField]
        private BoolGameObjectFunction IsNotUsed = null;

        public override GameObject Call(Vector3 position, Quaternion quaternion)
        {
            if (IsNotUsed == null)
            {
#if UNITY_EDITOR
                AtomsLogger.Warning("IsUsed must be defined when using GetUnusedGameObject");
#endif
            }

            return List.List.GetOrInstantiate(Prefab, position, quaternion, IsNotUsed.Call);
        }
    }
}
