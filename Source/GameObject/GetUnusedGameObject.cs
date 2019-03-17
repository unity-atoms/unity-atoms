using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms.Extensions;

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
                Debug.LogWarning("IsUsed must be defined!");
            }

            return List.List.GetOrInstantiate(Prefab, position, quaternion, IsNotUsed.Call);
        }
    }
}
