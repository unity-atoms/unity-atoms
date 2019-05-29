using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.Mobile
{
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/TouchUserInput", fileName = "TouchUserInputVariable")]
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
