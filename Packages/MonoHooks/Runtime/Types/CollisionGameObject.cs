using System;
using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    [Serializable]
    public struct CollisionGameObject : IEquatable<CollisionGameObject>
    {
        public Collision Collision { get => _collision; set => _collision = value; }
        public GameObject GameObject { get => _gameObject; set => _gameObject = value; }


        [SerializeField]
        private Collision _collision;

        [SerializeField]
        private GameObject _gameObject;


        /// <summary>
        /// Determine if 2 `Collider2DGameObject` are equal.
        /// </summary>
        /// <param name="other">The other `Collider2DGameObject` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public bool Equals(CollisionGameObject other)
        {
            return this.Collision == other.Collision && this.GameObject == other.GameObject;
        }

        /// <summary>
        /// Determine if 2 `Collider2DGameObject` are equal comparing against another `object`.
        /// </summary>
        /// <param name="obj">The other `object` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            CollisionGameObject cgo = (CollisionGameObject)obj;
            return Equals(cgo);
        }

        /// <summary>
        /// `GetHashCode()` in order to implement `IEquatable&lt;Collider2DGameObject&gt;`
        /// </summary>
        /// <returns>An unique hashcode for the current value.</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.Collision.GetHashCode();
            hash = hash * 23 + this.GameObject.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Equality operator
        /// </summary>
        /// <param name="first">First `Collider2DGameObject`.</param>
        /// <param name="second">Other `Collider2DGameObject`.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public static bool operator ==(CollisionGameObject first, CollisionGameObject second)
        {
            return first.Equals(second);
        }

        /// <summary>
        /// Inequality operator
        /// </summary>
        /// <param name="first">First `Collider2DGameObject`.</param>
        /// <param name="second">Other `Collider2DGameObject`.</param>
        /// <returns>`true` if they are not equal, otherwise `false`.</returns>
        public static bool operator !=(CollisionGameObject first, CollisionGameObject second)
        {
            return !first.Equals(second);
        }
    }
}
