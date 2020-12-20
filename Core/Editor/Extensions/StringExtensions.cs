using System;
using System.Text;

namespace UnityAtoms
{
    /// <summary>
    /// Internal extension class for strings.
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        /// Tries to parse a string to an int.
        /// </summary>
        /// <param name="str">The string to parse.</param>
        /// <param name="def">The default value if not able to parse the provided string.</param>
        /// <returns>Returns the string parsed to an int. If not able to parse the string, it returns the default value provided to the method.</returns>
        public static int ToInt(this string str, int def)
        {
            int num;
            return int.TryParse(str, out num) ? num : def;
        }

        /// <summary>
        /// Repeats the string X amount of times.
        /// </summary>
        /// <param name="str">The string to repeat.</param>
        /// <param name="times">The number of times to repeat the provided string.</param>
        /// <returns>The string repeated X amount of times.</returns>
        public static string Repeat(this string str, int times)
            => times == 1 ? str : new StringBuilder(str.Length * times).Insert(0, str, times).ToString();
    }
}
