using UnityEngine;
#if UNITY_EDITOR
using UnityAtoms.Logger;
#endif

namespace UnityAtoms.Examples
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Health Logger")]
    public sealed class HealthLogger : IntAction
    {
        public override void Do(int health)
        {
#if UNITY_EDITOR
            AtomsLogger.Log("<3: " + health);
#endif
        }
    }
}
