using UnityEngine;

namespace UnityAtoms.Examples
{
    [AddComponentMenu("Unity Atoms/Examples/PlayerMove")]
    public class PlayerMove : MonoBehaviour
    {
        private float _horizontal;
        private float _vertical;

        private void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");
        }

        private void FixedUpdate()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(_horizontal, _vertical) * 5f;
        }
    }
}
