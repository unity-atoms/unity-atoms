using UnityEngine;

namespace UnityAtoms
{
    public static class Vector3Extensions
    {
        public static Vector2 ToVector2(this Vector2 v3)
        {
            return new Vector2(v3.x, v3.y);
        }

        public static Vector3 TowardsTarget(this Vector3 v3, Vector3 target, float maxDistance)
        {
            var distance = target - v3;
            return v3 + (distance.normalized * maxDistance);
        }
    }
}