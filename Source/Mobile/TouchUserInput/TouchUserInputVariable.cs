using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.Mobile
{
    [CreateAssetMenu(menuName = "Unity Atoms/Mobile/Touch User Input/Variable", fileName = "TouchUserInputVariable", order = CreateAssetMenuUtils.Order.VARIABLE)]
    public sealed class TouchUserInputVariable : ScriptableObjectVariable<
        TouchUserInput,
        TouchUserInputGameEvent,
        TouchUserInputTouchUserInputGameEvent>
    {
        [FormerlySerializedAs("DetectTap")]
        [SerializeField]
        private DetectTap _detectTap = null;

        private void OnEnable()
        {
            if (_detectTap.InUse())
            {
                Changed.RegisterListener(_detectTap);
            }
        }

        private void OnDisable()
        {
            if (_detectTap.InUse())
            {
                Changed.UnregisterListener(_detectTap);
            }
        }

        public bool IsPotentialDoubleTapInProgress()
        {
            return _detectTap != null && _detectTap.InUse() && _detectTap.IsPotentialDoubleTapInProgress();
        }

        protected override bool AreEqual(TouchUserInput first, TouchUserInput second)
        {
            return first.Equals(second);
        }
    }

}
