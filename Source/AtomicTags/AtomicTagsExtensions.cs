using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms.Tags
{
    public static class AtomicTagsExtensions
    {
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
    }
}
