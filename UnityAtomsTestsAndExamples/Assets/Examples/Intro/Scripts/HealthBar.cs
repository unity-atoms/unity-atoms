using UnityEngine;
using UnityEngine.UI;

namespace UnityAtoms.Examples
{
    [AddComponentMenu("Unity Atoms/Examples/HealthBar")]
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private IntConstant _maxHealth = null;

        public void HealthChanged(int health)
        {
            GetComponent<Image>().fillAmount = 1.0f * health / _maxHealth.Value;
        }
    }
}
