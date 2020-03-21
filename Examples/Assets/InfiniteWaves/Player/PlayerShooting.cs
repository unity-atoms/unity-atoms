using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Simple shooting scipt for the player using the arrow keys.
    /// </summary>
    public class PlayerShooting : MonoBehaviour
    {
        [SerializeField]
        private GameObject _projectile;

        [SerializeField]
        private StringConstant _playerTag;


        void Update()
        {
            var shootDirection = Vector3.zero;
            var rot = Quaternion.identity;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                shootDirection = Vector3.up;
                rot = Quaternion.Euler(0f, 0f, 90f);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                shootDirection = Vector3.down;
                rot = Quaternion.Euler(0f, 0f, -90f);

            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                shootDirection = Vector3.right;
                rot = Quaternion.Euler(0f, 0f, 0f);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                shootDirection = Vector3.left;
                rot = Quaternion.Euler(0f, 0f, 180f);
            }


            if (shootDirection != Vector3.zero)
            {
                var spawnPos = transform.position + shootDirection * 0.6f;
                var projectile = Instantiate(_projectile, spawnPos, rot);
                projectile.GetComponent<DecreaseHealth>().TagsAffected.Remove(_playerTag); // Turn off friendly fire
            }
        }
    }
}