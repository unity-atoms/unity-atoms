// using UnityEngine;
// using UnityEngine.UI;
// using UniRx;

// namespace UnityAtoms.Examples
// {
//     public class HealthBarUniRx : MonoBehaviour
//     {
//         [SerializeField]
//         private IntConstant _maxHealth = null;
//         [SerializeField]
//         private IntVariable _health = null;

//         void Awake()
//         {
//             _health.ObserveChange().Subscribe(health =>
//             {
//                 GetComponent<Image>().fillAmount = 1.0f * health / _maxHealth.Value;
//             });
//         }
//     }
// }
