using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityAtoms
{
    public static class GameObjectExtensions
    {
        #region AtomicTagExtensions
        
            /// <summary>
            /// Retrieves all AtomicTags for a given GameObject
            /// </summary>
            /// <returns>
            /// - null if the GameObject does not have Atomic Tags or they (or the GO) are disabled)
            /// - an array of strings containing the tags
            /// </returns>
            public static string[] GetAtomicTags(this GameObject go) {
                return AtomicTags.GetAtomicTags(go);
            }

            /// <returns>
            /// - False if the GameObject does not have the AtomicTag, else True
            /// </returns>
            public static bool HasTag(this GameObject go, string str) {
                var atomicTags = AtomicTags.GetForGameObject(go);
                if (atomicTags == null) return false;

                var tags = atomicTags.Tags;
                for (int i = 0; tags != null && i < tags.Length; ++i)
                {
                    if (tags[i].Value == str)
                    {
                        return true;
                    }
                }
    
                return false;
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

                strings.Sort();
                var tags = atomicTags.Tags;

                // this makes use of Tags being always sorted
                // instead of O(n*m) this is worst case: O(n + m) +(because of the sort) O(n * log(n))
                // O(n*m) ~= O(n^2)  <-> O(n+m)+O(n * log(n)) ~= O(3n * log(n))
                for (int i = 0, j = 0; i < strings.Count && j < tags.Length;) {
                    var x = String.CompareOrdinal(strings[i], tags[j].Value);
                    if (x == 0) {
                        return true;
                    }
                    if (x > 0) {
                        ++j;
                    } else {
                        ++i;
                    }
                }
                return false;
            }
            
            
            public static bool HasAnyTag(this GameObject go, List<StringConstant> stringConstants)
            {
                // basically same method as above, the code is mostly copy and pasted because its not preferable to convert
                // stringconstants to strings and calling the other method, because of memory allocation
                var atomicTags = AtomicTags.GetForGameObject(go);
                if (atomicTags == null) return false;

                stringConstants.Sort((x, y) => String.Compare(x.Value, y.Value, StringComparison.Ordinal));
                var tags = atomicTags.Tags;

                for (int i = 0, j = 0; i < stringConstants.Count && j < tags.Length;) {
                    var x = String.CompareOrdinal(stringConstants[i].Value, tags[j].Value);
                    if (x == 0) {
                        return true;
                    }
                    if (x > 0) {
                        ++j;
                    } else {
                        ++i;
                    }
                }
                return false;
            }
        #endregion
    }
}