using UnityEngine;

namespace UnityAtoms.Extensions
{
    public static class CameraExtensions
    {
        public static float GetOrthographicWorldScreenHeight(this Camera camera)
        {
            return camera.orthographicSize * 2f;
        }

        public static float GetOrthographicWorldScreenWidth(this Camera camera)
        {
            return camera.GetOrthographicWorldScreenHeight() / Screen.height * Screen.width; ;
        }
    }
}