using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public class DetectTap : IGameEventListener<TouchUserInput>
    {
        [SerializeField]
        private Timer FirstTapTimer;
        [SerializeField]
        private Timer SecondTapTimer;
        [SerializeField]
        private FloatReference MaxTimeBetweenTaps;
        [SerializeField]
        private FloatReference MaxDistanceBetweenTaps;
        [SerializeField]
        private FloatReference MaxMovementToCountAsTap;
        [SerializeField]
        private TouchUserInputGameEvent OnTapDetectedEvent;
        [SerializeField]
        private TouchUserInputGameEvent OnDoubleTapDetectedEvent;

        private Vector2 inputPosFirstTapDown;

        private void OnEnable()
        {
            FirstTapTimer.Stop();
            SecondTapTimer.Stop();
        }

        public void OnEventRaised(TouchUserInput touchUserInput)
        {
            if (!IsPotentialDoubleTapInProgress())
            {
                FirstTapTimer.Stop();
                SecondTapTimer.Stop();
            }

            if (touchUserInput.InputState == TouchUserInput.State.Down && CanStartDoubleTap())
            {
                inputPosFirstTapDown = touchUserInput.InputPos;
                FirstTapTimer.Start();
            }
            else if (touchUserInput.InputState == TouchUserInput.State.Drag && FirstTapTimer.IsStarted() && Vector2.Distance(touchUserInput.InputPos, inputPosFirstTapDown) > MaxMovementToCountAsTap.Value)
            {
                FirstTapTimer.Stop();
            }
            else if (touchUserInput.InputState == TouchUserInput.State.Up && WaitingForFinishingFirstTap())
            {
                if (FirstTapTimer.GetElapsedTime() <= MaxTimeBetweenTaps.Value)
                {
                    if (OnTapDetectedEvent != null)
                    {
                        OnTapDetectedEvent.Raise(touchUserInput);
                    }
                    SecondTapTimer.Start();
                }
                FirstTapTimer.Stop();
            }
            else if (touchUserInput.InputState == TouchUserInput.State.Down && WaitingForSecondTap())
            {
                if (Vector2.Distance(touchUserInput.InputPos, inputPosFirstTapDown) <= MaxDistanceBetweenTaps.Value && SecondTapTimer.GetElapsedTime() <= MaxTimeBetweenTaps.Value)
                {
                    if (OnDoubleTapDetectedEvent != null)
                    {
                        OnDoubleTapDetectedEvent.Raise(touchUserInput); // OPEN POINT: Should we raise event on state up or down?
                    }
                }
                SecondTapTimer.Stop();
            }
        }

        private bool CanStartDoubleTap()
        {
            return !SecondTapTimer.IsStarted();
        }

        private bool WaitingForFinishingFirstTap()
        {
            return FirstTapTimer.IsStarted();
        }

        private bool WaitingForSecondTap()
        {
            return SecondTapTimer.IsStarted();
        }

        public bool IsPotentialDoubleTapInProgress()
        {
            return (FirstTapTimer.IsStarted() && FirstTapTimer.GetElapsedTime() <= MaxTimeBetweenTaps.Value) || (SecondTapTimer.IsStarted() && SecondTapTimer.GetElapsedTime() <= MaxTimeBetweenTaps.Value);
        }

        public bool InUse()
        {
            return FirstTapTimer != null && SecondTapTimer != null && OnDoubleTapDetectedEvent != null;
        }
    }

}
