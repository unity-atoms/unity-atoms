using System;
using UnityEngine;

namespace UnityAtoms.MonoHooks
{
    [Serializable]
    public struct ColliderGameObject : IEquatable<ColliderGameObject>
    {
        public Collider Collider { get => _collider; set => _collider = value; }
        public GameObject GameObject { get => _gameObject; set => _gameObject = value; }


        [SerializeField]
        private Collider _collider;

        [SerializeField]
        private GameObject _gameObject;


        /// <summary>
        /// Determine if 2 `ColliderGameObject` are equal.
        /// </summary>
        /// <param name="other">The other `ColliderGameObject` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public bool Equals(ColliderGameObject other)
        {
            return this.Collider == other.Collider && this.GameObject == other.GameObject;
        }

        /// <summary>
        /// Determine if 2 `ColliderGameObject` are equal comparing against another `object`.
        /// </summary>
        /// <param name="obj">The other `object` to compare with.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            ColliderGameObject cgo = (ColliderGameObject)obj;
            return Equals(cgo);
        }

        /// <summary>
        /// `GetHashCode()` in order to implement `IEquatable&lt;ColliderGameObject&gt;`
        /// </summary>
        /// <returns>An unique hashcode for the current value.</returns>
        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.Collider.GetHashCode();
            hash = hash * 23 + this.GameObject.GetHashCode();
            return hash;
        }

        /// <summary>
        /// Equality operator
        /// </summary>
        /// <param name="first">First `ColliderGameObject`.</param>
        /// <param name="second">Other `ColliderGameObject`.</param>
        /// <returns>`true` if equal, otherwise `false`.</returns>
        public static bool operator ==(ColliderGameObject first, ColliderGameObject second)
        {
            return first.Equals(second);
        }

        /// <summary>
        /// Inequality operator
        /// </summary>
        /// <param name="first">First `ColliderGameObject`.</param>
        /// <param name="second">Other `ColliderGameObject`.</param>
        /// <returns>`true` if they are not equal, otherwise `false`.</returns>
        public static bool operator !=(ColliderGameObject first, ColliderGameObject second)
        {
            return !first.Equals(second);
        }
    }
}