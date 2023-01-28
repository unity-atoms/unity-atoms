using System;
using UnityEngine;
using UnityAtoms;

namespace UnityAtoms.Mobile
{
    /// <summary>
    /// Module class holding data for touch user input.
    /// </summary>
    [Serializable]
    public struct TouchUserInput : IEquatable<TouchUserInput>
    {
        /// <summary>
        /// Enum for different touch user input states.
        /// </summary>
        public enum State
        {
            None,
            Down,
            Drag,
            Up
        };

        /// <summary>
        /// Current input state.
        /// </summary>
        public State InputState;

        /// <summary>
        /// Current input position.
        /// </summary>
        public Vector2 InputPos;

        /// <summary>
        /// Input position last frame.
        /// </summary>
        public Vector2 InputPosLastFrame;

        /// <summary>
        /// Input position last time the user pressed down.
        /// </summary>
        public Vector2 InputPosLastDown;

        /// <summary>
        /// The input position in world space.
        /// </summary>
        /// <returns>The input position in world space.</returns>
        public Vector2 InputWorldPos { get { return Camera.main.ScreenToWorldPoint(InputPos); } }

        /// <summary>
        /// The input position in world space from last frame.
        /// </summary>
        /// <returns>The input position in world space from last frame.</returns>
        public Vector2 InputWorldPosLastFrame { get { return Camera.main.ScreenToWorldPoint(InputPosLastFrame); } }

        /// <summary>
        /// Input position last time the user pressed down in world space.
        /// </summary>
        /// <returns>Input position last time the user pressed down in world space.</returns>
        public Vector2 InputWorldPosLastDown { get { return Camera.main.ScreenToWorldPoint(InputPosLastDown); } }

        /// <summary>
        /// Create a `TouchUserInput` class.
        /// </summary>
        /// <param name="inputState">Initial input state.</param>
        /// <param name="inputPos">Initial input position.</param>
        /// <param name="inputPosLastFrame">Initial input position last frame.</param>
        /// <param name="inputPosLastDown">Initial input position last time the user pressed down.</param>
        public TouchUserInput(State inputState, Vector2 inputPos, Vector2 inputPosLastFrame, Vector2 inputPosLastDown)
        {
            this.InputState = inputState;
            this.InputPos = inputPos;
            this.InputPosLastFrame = inputPosLastFrame;
            this.InputPosLastDown = inputPosLastDown;
        }

        /// <summary>
        /// Determine if 2 `TouchUserInput` are equal.
        /// </summary>
        /// <param name="other">The other `TouchUserInput` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public bool Equals(TouchUserInput other)
        {
            return this.InputState == other.InputState && this.InputWorldPos == other.InputWorldPos && this.InputWorldPosLastFrame == other.InputWorldPosLastFrame && this.InputPosLastDown == other.InputPosLastDown;
        }

        /// <summary>
        /// Determine if 2 `TouchUserInput` are equal comparing against another `object`.
        /// </summary>
        /// <param name="obj">The other `object` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            TouchUserInput tui = (TouchUserInput)obj;
            return Equals(tui);
        }

        /// <summary>
        /// `GetHashCode()` in order to implement `IEquatable&lt;TouchUserInput&gt;`
        /// </summary>
        /// <returns>An unique hashcode for the current value.</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.InputState.GetHashCode();
            hash = hash * 23 + this.InputPos.GetHashCode();
            hash = hash * 23 + this.InputPosLastFrame.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Equality operator
        /// </summary>
        /// <param name="touch1">First `TouchUserInput`.</param>
        /// <param name="touch2">Other `TouchUserInput`.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public static bool operator ==(TouchUserInput touch1, TouchUserInput touch2)
        {
            return touch1.Equals(touch2);
        }

        /// <summary>
        /// Inequality operator
        /// </summary>
        /// <param name="touch1">First `TouchUserInput`.</param>
        /// <param name="touch2">Other `TouchUserInput`.</param>
        /// <returns>`true` if they are not equal, otherwise `false`.</returns>
        public static bool operator !=(TouchUserInput touch1, TouchUserInput touch2)
        {
            return !touch1.Equals(touch2);
        }
    }
}
