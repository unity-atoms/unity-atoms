using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Extensions
{
    public static class GameObjectExtensions
    {
        #region AtomicTagExtensions

        /// <summary>
        /// Retrieves all AtomicTags for a given GameObject
        /// </summary>
        /// <returns>
        /// - null if the GameObject does not have Atomic Tags or they (or the GO) are disabled)
        /// - an readonly list of strings containing the tags
        /// </returns>
        public static ReadOnlyList<StringConstant> GetAtomicTags(this GameObject go)
        {
            return AtomicTags.GetAtomicTags(go);
        }

        /// <returns>
        /// - False if the GameObject does not have the AtomicTag, else True
        /// </returns>
        public static bool HasTag(this GameObject go, string tag)
        {
            var atomicTags = AtomicTags.GetForGameObject(go);
            if (atomicTags == null) return false;
            return atomicTags.HasTag(tag);
        }

        /// <returns>
        /// - False if the GameObject does not have the AtomicTag, else True
        /// </returns>
        public static bool HasTag(this GameObject go, StringConstant stringConstant)
        {
            return go.HasTag(stringConstant.Value);
        }


        public static bool HasAnyTag(this GameObject go, List<string> strings)
        {
            var atomicTags = AtomicTags.GetForGameObject(go);
            if (atomicTags == null) return false;

            for (var i = 0; i < strings.Count; i++)
            {
                if (atomicTags.HasTag(strings[i])) return true;
            }
            return false;
        }


        public static bool HasAnyTag(this GameObject go, List<StringConstant> stringConstants)
        {
            // basically same method as above, the code is mostly copy and pasted because its not preferable to convert
            // stringconstants to strings and calling the other method, because of memory allocation
            var atomicTags = AtomicTags.GetForGameObject(go);
            if (atomicTags == null) return false;

            for (var i = 0; i < stringConstants.Count; i++)
            {
                if (atomicTags.HasTag(stringConstants[i].Value)) return true;
            }
            return false;
        }
        #endregion

        // Tries to get a component on the the GameObject. If the component doesn't exists it adds it and return the newly added component.
        public static T GetOrAddComponent<T>(this GameObject go) where T : Component
        {
            return go.GetComponent<T>() == null ? go.AddComponent<T>() : go.GetComponent<T>();
        }

        public static bool HasComponent<T>(this GameObject go) where T : Component
        {
            return go.GetComponent<T>() != null;
        }
    }
}
