using UnityEngine;

namespace UnityAtoms.Examples
{
    public class HarmfulTrigger : MonoBehaviour
    {
        [SerializeField]
        private Collider2DEvent _harmfullEvent;

        private void OnTriggerEnter2D(Collider2D other)
        {
            _harmfullEvent.Raise(other);
        }
    }
}
