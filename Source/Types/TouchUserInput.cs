using System;
using UnityEngine;

namespace UnityAtoms.Mobile
{
    [Serializable]
    public struct TouchUserInput : IEquatable<TouchUserInput>
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

        public override bool Equals(object obj)
        {
            TouchUserInput tui = (TouchUserInput)obj;
            return Equals(tui);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + this.InputState.GetHashCode();
            hash = hash * 31 + this.InputPos.GetHashCode();
            hash = hash * 31 + this.InputPosLastFrame.GetHashCode();
            return hash;
        }

        public static bool operator ==(TouchUserInput touch1, TouchUserInput touch2)
        {
            return touch1.Equals(touch2);
        }

        public static bool operator !=(TouchUserInput touch1, TouchUserInput touch2)
        {
            return !touch1.Equals(touch2);
        }
    }
}
