using UnityEngine;

namespace UnityAtoms
{
    public static class Vector2Extensions
    {
        public static Vector3 ToVector3(this Vector2 v2, float z = 0f)
        {
            return new Vector3(v2.x, v2.y, z);
        }

        public static Vector3 ToWorldPos(this Vector2 v2)
        {
            return Camera.main.ScreenToWorldPoint(v2);
        }

        public static Vector2 TowardsTarget(this Vector2 v2, Vector2 target, float maxDistance)
        {
            var distance = target - v2;
            return v2 + (distance.normalized * maxDistance);
        }
    }
}