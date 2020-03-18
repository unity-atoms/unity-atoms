using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class MoveInDirection : MonoBehaviour
    {
        public float Speed { set => _speed.Value = value; }

        [SerializeField]
        private FloatReference _speed;

        private Rigidbody2D rb;

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            rb.isKinematic = true;
        }

        void Update()
        {
            rb.velocity = transform.right * _speed.Value;
        }
    }
}
