using UnityEngine;
using UnityEngine.UI;
using UnityAtoms;

namespace UnityAtoms.Examples
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField]
        private IntConstant MaxHealth;

        public void HealthChanged(int health)
        {
            GetComponent<Image>().fillAmount = 1.0f * health / MaxHealth.Value;
        }
    }
}