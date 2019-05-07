using UnityEngine;

namespace UnityAtoms
{
    internal static class IMGUIUtils
    {
        private static Rect SnipRectH(Rect rect, float range)
        {
            if (range == 0) return new Rect(rect);
            if (range > 0)
            {
                return new Rect(rect.x, rect.y, range, rect.height);
            }

            return new Rect(rect.x + rect.width + range, rect.y, -range, rect.height);
        }

        public static Rect SnipRectH(Rect rect, float range, out Rect rest, float gutter = 0f)
        {
            if (range == 0) rest = new Rect();
            if (range > 0)
            {
                rest = new Rect(rect.x + range + gutter, rect.y, rect.width - range - gutter, rect.height);
            }
            else
            {
                rest = new Rect(rect.x, rect.y, rect.width + range + gutter, rect.height);
            }

            return SnipRectH(rect, range);
        }

        private static Rect SnipRectV(Rect rect, float range)
        {
            if (range == 0) return new Rect(rect);
            if (range > 0)
            {
                return new Rect(rect.x, rect.y, rect.width, range);
            }

            return new Rect(rect.x, rect.y + rect.height + range, rect.width, -range);
        }

        public static Rect SnipRectV(Rect rect, float range, out Rect rest, float gutter = 0f)
        {
            if (range == 0) rest = new Rect();
            if (range > 0)
            {
                rest = new Rect(rect.x, rect.y + range + gutter, rect.width, rect.height - range - gutter);
            }
            else
            {
                rest = new Rect(rect.x, rect.y, rect.width, rect.height + range + gutter);
            }

            return SnipRectV(rect, range);
        }
    }
}
