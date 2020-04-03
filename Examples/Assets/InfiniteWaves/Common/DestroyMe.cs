using UnityEngine;
using UnityEngine.Assertions;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Script intending to destroy the GameObject it's attached to.
    /// </summary>
    public class DestroyMe : MonoBehaviour
    {
        [SerializeField]
        FloatReference _delay = new FloatReference(-1f);

        void Start()
        {
            Assert.IsNotNull(_delay);
            if (_delay.Value >= 0f)
            {
                Destroy(gameObject, _delay.Value);
            }
        }

        public void DestroyImmediate() => Destroy(gameObject);

        public void DestroyIfZeroOrBelow(int value)
        {
            if (value <= 0)
            {
                DestroyImmediate();
            }
        }
    }
}
