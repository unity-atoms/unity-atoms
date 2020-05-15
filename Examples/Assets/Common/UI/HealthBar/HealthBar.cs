using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.Examples
{
    /// <summary>
    /// A healthbar component that sets the fill amount of its associated UI Image accordingly.
    /// </summary>
    [AddComponentMenu("Unity Atoms/Examples/HealthBar")]
    public class HealthBar : MonoBehaviour
    {
        public AtomReference<int> InitialHealth { get => _initialHealth; }

        [SerializeField]
        private AtomReference<int> _initialHealth = null;

        [SerializeField]
        private Image _image;

        void Awake()
        {
            if (_image == null)
            {
                _image = GetComponent<Image>();
            }
        }

        public void HealthChanged(int health) => _image.fillAmount = 1.0f * health / _initialHealth.Value;
    }
}
