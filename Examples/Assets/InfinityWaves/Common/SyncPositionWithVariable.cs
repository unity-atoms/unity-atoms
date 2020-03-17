using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
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

