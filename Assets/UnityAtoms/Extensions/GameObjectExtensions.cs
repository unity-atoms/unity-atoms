using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public static class GameObjectExtensions
    {
        public static List<StringConstant> GetTags(this GameObject go)
        {
            return go.GetComponent<AtomicTags>() ? go.GetComponent<AtomicTags>().Tags : null;
        }

        public static bool HasTag(this GameObject go, string str)
        {
            var tags = go.GetComponent<AtomicTags>() ? go.GetComponent<AtomicTags>().Tags : null;

            for (int i = 0; tags != null && i < tags.Count; ++i)
            {
                if (tags[i].Value == str)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool HasTag(this GameObject go, StringConstant stringConstant)
        {
            return go.HasTag(stringConstant.Value);
        }

        public static bool HasAnyTag(this GameObject go, List<StringConstant> stringConstants)
        {
            for (int i = 0; stringConstants != null && i < stringConstants.Count; ++i)
            {
                if (go.HasTag(stringConstants[i].Value))
                {
                    return true;
                }
            }

            return false;
        }
    }
}