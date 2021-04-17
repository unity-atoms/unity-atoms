using System;
using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    [Serializable]
    public struct Collision2DGameObject : IEquatable<Collision2DGameObject>
    {
        public Collision2D Collision2D { get => _collision2D; set => _collision2D = value; }
        public GameObject GameObject { get => _gameObject; set => _gameObject = value; }


        [SerializeField]
        private Collision2D _collision2D;

        [SerializeField]
        private GameObject _gameObject;


        /// <summary>
        /// Determine if 2 `Collider2DGameObject` are equal.
        /// </summary>
        /// <param name="other">The other `Collider2DGameObject` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public bool Equals(Collision2DGameObject other)
        {
            return this.Collision2D == other.Collision2D && this.GameObject == other.GameObject;
        }

        /// <summary>
        /// Determine if 2 `Collider2DGameObject` are equal comparing against another `object`.
        /// </summary>
        /// <param name="obj">The other `object` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            Collision2DGameObject cgo = (Collision2DGameObject)obj;
            return Equals(cgo);
        }

        /// <summary>
        /// `GetHashCode()` in order to implement `IEquatable&lt;Collider2DGameObject&gt;`
        /// </summary>
        /// <returns>An unique hashcode for the current value.</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.Collision2D.GetHashCode();
            hash = hash * 23 + this.GameObject.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Equality operator
        /// </summary>
        /// <param name="first">First `Collider2DGameObject`.</param>
        /// <param name="second">Other `Collider2DGameObject`.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public static bool operator ==(Collision2DGameObject first, Collision2DGameObject second)
        {
            return first.Equals(second);
        }

        /// <summary>
        /// Inequality operator
        /// </summary>
        /// <param name="first">First `Collider2DGameObject`.</param>
        /// <param name="second">Other `Collider2DGameObject`.</param>
        /// <returns>`true` if they are not equal, otherwise `false`.</returns>
        public static bool operator !=(Collision2DGameObject first, Collision2DGameObject second)
        {
            return !first.Equals(second);
        }
    }
}
