using System;
using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    [Serializable]
    public struct Collider2DGameObject : IEquatable<Collider2DGameObject>
    {
        public Collider2D Collider2D { get => _collider2D; set => _collider2D = value; }
        public GameObject GameObject { get => _gameObject; set => _gameObject = value; }


        [SerializeField]
        private Collider2D _collider2D;

        [SerializeField]
        private GameObject _gameObject;


        /// <summary>
        /// Determine if 2 `Collider2DGameObject` are equal.
        /// </summary>
        /// <param name="other">The other `Collider2DGameObject` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public bool Equals(Collider2DGameObject other)
        {
            return this.Collider2D == other.Collider2D && this.GameObject == other.GameObject;
        }

        /// <summary>
        /// Determine if 2 `Collider2DGameObject` are equal comparing against another `object`.
        /// </summary>
        /// <param name="obj">The other `object` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            Collider2DGameObject cgo = (Collider2DGameObject)obj;
            return Equals(cgo);
        }

        /// <summary>
        /// `GetHashCode()` in order to implement `IEquatable&lt;Collider2DGameObject&gt;`
        /// </summary>
        /// <returns>An unique hashcode for the current value.</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.Collider2D.GetHashCode();
            hash = hash * 23 + this.GameObject.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Equality operator
        /// </summary>
        /// <param name="first">First `Collider2DGameObject`.</param>
        /// <param name="second">Other `Collider2DGameObject`.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public static bool operator ==(Collider2DGameObject first, Collider2DGameObject second)
        {
            return first.Equals(second);
        }

        /// <summary>
        /// Inequality operator
        /// </summary>
        /// <param name="first">First `Collider2DGameObject`.</param>
        /// <param name="second">Other `Collider2DGameObject`.</param>
        /// <returns>`true` if they are not equal, otherwise `false`.</returns>
        public static bool operator !=(Collider2DGameObject first, Collider2DGameObject second)
        {
            return !first.Equals(second);
        }
    }
}