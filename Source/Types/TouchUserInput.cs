using System;
using UnityEngine;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public struct TouchUserInput
    {
        public enum State
        {
            None,
            Down,
            Drag,
            Up
        };

        public State InputState;
        public Vector2 InputPos;
        public Vector2 InputPosLastFrame;
        public Vector2 InputPosLastDown;
        public Vector2 InputWorldPos { get { return Camera.main.ScreenToWorldPoint(InputPos); } }
        public Vector2 InputWorldPosLastFrame { get { return Camera.main.ScreenToWorldPoint(InputPosLastFrame); } }
        public Vector2 InputWorldPosLastDown { get { return Camera.main.ScreenToWorldPoint(InputPosLastDown); } }

        public TouchUserInput(State inputState, Vector2 inputPos, Vector2 inputPosLastFrame, Vector2 inputPosLastDown)
        {
            this.InputState = inputState;
            this.InputPos = inputPos;
            this.InputPosLastFrame = inputPosLastFrame;
            this.InputPosLastDown = inputPosLastDown;
        }

        public bool Equals(TouchUserInput other)
        {
            return this.InputState == other.InputState && this.InputWorldPos == other.InputWorldPos && this.InputWorldPosLastFrame == other.InputWorldPosLastFrame;
        }
    }
}
