using UnityEngine;
using UnityEngine.UI;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    [AddComponentMenu("Unity Atoms/Examples/HealthBar")]
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private IntReference _initialHealth = null;

        [SerializeField]
        private Image _image;

        void Awake()
        {
            if (_image == null)
            {
                _image = GetComponent<Image>();
            }
        }

        public void HealthChanged(int health)
        {
            _image.fillAmount = 1.0f * health / _initialHealth.Value;
        }
    }
}
