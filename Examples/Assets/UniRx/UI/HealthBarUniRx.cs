using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// Simple healthbar script using UniRx.
    /// </summary>
    public class HealthBarUniRx : MonoBehaviour
    {
        [SerializeField]
        private IntVariable _health = null;

        void Awake()
        {
            _health.ObserveChange().Subscribe(health =>
            {
                GetComponent<Image>().fillAmount = 1.0f * health / _health.InitialValue;
            });
        }
    }
}
