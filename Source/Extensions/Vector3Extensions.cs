using UnityEngine;

namespace UnityAtoms.Extensions
{
    public enum V3Axis { x, y, z }
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

        public static Vector3 CloneAndChange(this Vector3 v3, V3Axis axis, float val)
        {
            return new Vector3(
                axis == V3Axis.x ? val : v3.x,
                axis == V3Axis.y ? val : v3.y,
                axis == V3Axis.z ? val : v3.z
            );
        }
    }
}