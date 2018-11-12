using UnityEngine;
using UnityEngine.UI;
using UnityAtoms;

namespace UnityAtoms.Examples
{
    public class Harmful : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.tag == "Player")
            {
                collider.GetComponent<PlayerHealth>().Health.Value -= 10;
            }
        }
    }
}