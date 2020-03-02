using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms.Examples
{
    [CreateAssetMenu(menuName = "Unity Atoms/Examples/Intro/Reset Health", fileName = "ResetHealth")]
    public class ResetHealth : VoidAction
    {
        [SerializeField]
        private IntVariable _variable = null;

        public override void Do()
        {
            _variable.Reset(true);
        }
    }
}
