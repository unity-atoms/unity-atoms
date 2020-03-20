using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Script to sync the Vector3 Variable with this GameObject's current position.
    /// </summary>
    public class SyncPositionWithVariable : MonoBehaviour
    {
        [SerializeField]
        private Vector3Reference _reference;

        void LateUpdate()
        {
            _reference.Value = transform.position;
        }
    }
}

