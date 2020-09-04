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
        public State TouchState { get => _touchState; set => _touchState = value; }
        [SerializeField] private State _touchState;

        /// <summary>
        /// Current input position.
        /// </summary>
        public Vector2 Position { get => _position; set => _position = value; }
        [SerializeField] private Vector2 _position;

        /// <summary>
        /// Input position last frame.
        /// </summary>
        public Vector2 PositionLastFrame { get => _positionLastFrame; set => _positionLastFrame = value; }
        [SerializeField] private Vector2 _positionLastFrame;

        /// <summary>
        /// Input position last time the user pressed down.
        /// </summary>
        public Vector2 PositionLastDown { get => _positionLastDown; set => _positionLastDown = value; }
        [SerializeField] private Vector2 _positionLastDown;

        /// <summary>
        /// Create a `TouchUserInput` class.
        /// </summary>
        /// <param name="touchState">Initial input state.</param>
        /// <param name="position">Initial input position.</param>
        /// <param name="positionLastFrame">Initial input position last frame.</param>
        /// <param name="positionLastDown">Initial input position last time the user pressed down.</param>
        public TouchUserInput(State touchState, Vector2 position, Vector2 positionLastFrame, Vector2 positionLastDown)
        {
            this._touchState = touchState;
            this._position = position;
            this._positionLastFrame = positionLastFrame;
            this._positionLastDown = positionLastDown;
        }

        /// <summary>
        /// Returns the input position in world space.
        /// </summary>
        /// <param name="camera">`Camera` to call ScreenToWorldPoint method.</param>
        /// <returns>`Vector2` input position in world space.</returns>
        public Vector2 GetWorldPosition(Camera camera)
        {
            if (camera == null) return Vector2.zero;
            return camera.ScreenToWorldPoint(Position);
        }

        /// <summary>
        /// Returns the input position in world space from last frame.
        /// </summary>
        /// <param name="camera">`Camera` to call ScreenToWorldPoint method.</param>
        /// <returns>`Vector2` input position in world space from last frame.</returns>
        public Vector2 GetWorldPositionLastFrame(Camera camera)
        {
            if (camera == null) return Vector2.zero;
            return camera.ScreenToWorldPoint(PositionLastFrame);
        }

        /// <summary>
        /// Returns the input position last time the user pressed down in world space.
        /// </summary>
        /// <param name="camera">`Camera` to call ScreenToWorldPoint method.</param>
        /// <returns>`Vector2` input position last time the user pressed down in world space.</returns>
        public Vector2 GetWorldPositionLastDown(Camera camera)
        {
            if (camera == null) return Vector2.zero;
            return camera.ScreenToWorldPoint(PositionLastDown);
        }

        /// <summary>
        /// Determine if 2 `TouchUserInput` are equal.
        /// </summary>
        /// <param name="other">The other `TouchUserInput` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public bool Equals(TouchUserInput other)
        {
            return this.TouchState == other.TouchState && this.Position == other.Position && this.PositionLastFrame == other.PositionLastFrame && this.PositionLastDown == other.PositionLastDown;
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
            hash = hash * 23 + this.TouchState.GetHashCode();
            hash = hash * 23 + this.Position.GetHashCode();
            hash = hash * 23 + this.PositionLastFrame.GetHashCode();
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
