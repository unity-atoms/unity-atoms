using UnityEngine;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Simple move script for the Player.
    /// </summary>
    [AddComponentMenu("Unity Atoms/Examples/PlayerMove")]
    public class PlayerMove : MonoBehaviour
    {
        private float _horizontal;
        private float _vertical;

        private void Update()
        {
            _horizontal = Input.GetAxis("Horizontal");
            _vertical = Input.GetAxis("Vertical");

            GetComponent<Rigidbody2D>().Move(new Vector2(_horizontal, _vertical), 5f, Time.deltaTime);
        }
    }
}