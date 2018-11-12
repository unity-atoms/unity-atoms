
using UnityEngine;

namespace UnityAtoms.Examples
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Game Actions/Health Logger")]
    public class HealthLogger : IntAction
    {
        public override void Do(int health)
        {
            Debug.Log("<3: " + health);
        }
    }
}