using UnityEngine;

namespace UnityAtoms.Mobile
{
    [CreateAssetMenu(menuName = "Unity Atoms/Mobile/Touch User Input/Variable", fileName = "TouchUserInputVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public class TouchUserInputVariable : EquatableScriptableObjectVariable<TouchUserInput, TouchUserInputGameEvent, TouchUserInputTouchUserInputGameEvent>
    {
        [SerializeField]
        private DetectTap DetectTap;

        private void OnEnable()
        {
            if (DetectTap.InUse())
            {
                Changed.RegisterListener(DetectTap);
            }
        }

        private void OnDisable()
        {
            if (DetectTap.InUse())
            {
                Changed.UnregisterListener(DetectTap);
            }
        }

        public bool IsPotentialDoubleTapInProgress()
        {
            return DetectTap != null && DetectTap.InUse() && DetectTap.IsPotentialDoubleTapInProgress();
        }
    }

}