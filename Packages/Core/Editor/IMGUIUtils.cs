using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Utility methods for IMGUI.
    /// </summary>
    public static class IMGUIUtils
    {
        /// <summary>
        /// Snip a `Rect` horizontally.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="range">The range.</param>
        /// <returns>A new `Rect` snipped horizontally.</returns>

        private static Rect SnipRectH(Rect rect, float range)
        {
            if (range == 0) return new Rect(rect);
            if (range > 0)
            {
                return new Rect(rect.x, rect.y, range, rect.height);
            }

            return new Rect(rect.x + rect.width + range, rect.y, -range, rect.height);
        }

        /// <summary>
        /// Snip a `Rect` horizontally.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="range">The range.</param>
        /// <param name="rest">Rest rect.</param>
        /// <param name="gutter">Gutter</param>
        /// <returns>A new `Rect` snipped horizontally.</returns>
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

        /// <summary>
        /// Snip a `Rect` vertically.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="range">The range.</param>
        /// <returns>A new `Rect` snipped vertically.</returns>
        private static Rect SnipRectV(Rect rect, float range)
        {
            if (range == 0) return new Rect(rect);
            if (range > 0)
            {
                return new Rect(rect.x, rect.y, rect.width, range);
            }

            return new Rect(rect.x, rect.y + rect.height + range, rect.width, -range);
        }

        /// <summary>
        /// Snip a `Rect` vertically.
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="range">The range.</param>
        /// <param name="rest">Rest rect.</param>
        /// <param name="gutter">Gutter</param>
        /// <returns>A new `Rect` snipped vertically.</returns>
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
