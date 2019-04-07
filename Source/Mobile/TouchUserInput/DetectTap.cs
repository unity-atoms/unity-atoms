using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public class DetectTap : IGameEventListener<TouchUserInput>
    {
        [FormerlySerializedAs("FirstTapTimer")]
        [SerializeField]
        private Timer _firstTapTimer;

        [FormerlySerializedAs("SecondTapTimer")]
        [SerializeField]
        private Timer _secondTapTimer;

        [FormerlySerializedAs("MaxTimeBetweenTaps")]
        [SerializeField]
        private FloatReference _maxTimeBetweenTaps;

        [FormerlySerializedAs("MaxDistanceBetweenTaps")]
        [SerializeField]
        private FloatReference _maxDistanceBetweenTaps;

        [FormerlySerializedAs("MaxMovementToCountAsTap")]
        [SerializeField]
        private FloatReference _maxMovementToCountAsTap;

        [FormerlySerializedAs("OnTapDetectedEvent")]
        [SerializeField]
        private TouchUserInputGameEvent _onTapDetectedEvent;

        [FormerlySerializedAs("OnDoubleTapDetectedEvent")]
        [SerializeField]
        private TouchUserInputGameEvent _onDoubleTapDetectedEvent;

        private Vector2 _inputPosFirstTapDown;

        public void OnEventRaised(TouchUserInput touchUserInput)
        {
            if (!IsPotentialDoubleTapInProgress())
            {
                _firstTapTimer.Stop();
                _secondTapTimer.Stop();
            }

            if (touchUserInput.InputState == TouchUserInput.State.Down && CanStartDoubleTap())
            {
                _inputPosFirstTapDown = touchUserInput.InputPos;
                _firstTapTimer.Start();
            }
            else if (touchUserInput.InputState == TouchUserInput.State.Drag && _firstTapTimer.IsStarted() && Vector2.Distance(touchUserInput.InputPos, _inputPosFirstTapDown) > _maxMovementToCountAsTap.Value)
            {
                _firstTapTimer.Stop();
            }
            else if (touchUserInput.InputState == TouchUserInput.State.Up && WaitingForFinishingFirstTap())
            {
                if (_firstTapTimer.GetElapsedTime() <= _maxTimeBetweenTaps.Value)
                {
                    if (_onTapDetectedEvent != null)
                    {
                        _onTapDetectedEvent.Raise(touchUserInput);
                    }
                    _secondTapTimer.Start();
                }
                _firstTapTimer.Stop();
            }
            else if (touchUserInput.InputState == TouchUserInput.State.Down && WaitingForSecondTap())
            {
                if (Vector2.Distance(touchUserInput.InputPos, _inputPosFirstTapDown) <= _maxDistanceBetweenTaps.Value && _secondTapTimer.GetElapsedTime() <= _maxTimeBetweenTaps.Value)
                {
                    if (_onDoubleTapDetectedEvent != null)
                    {
                        _onDoubleTapDetectedEvent.Raise(touchUserInput); // OPEN POINT: Should we raise event on state up or down?
                    }
                }
                _secondTapTimer.Stop();
            }
        }

        private bool CanStartDoubleTap()
        {
            return !_secondTapTimer.IsStarted();
        }

        private bool WaitingForFinishingFirstTap()
        {
            return _firstTapTimer.IsStarted();
        }

        private bool WaitingForSecondTap()
        {
            return _secondTapTimer.IsStarted();
        }

        public bool IsPotentialDoubleTapInProgress()
        {
            return (_firstTapTimer.IsStarted() && _firstTapTimer.GetElapsedTime() <= _maxTimeBetweenTaps.Value) || (_secondTapTimer.IsStarted() && _secondTapTimer.GetElapsedTime() <= _maxTimeBetweenTaps.Value);
        }

        public bool InUse()
        {
            return _firstTapTimer != null && _secondTapTimer != null && _onDoubleTapDetectedEvent != null;
        }
    }

}
