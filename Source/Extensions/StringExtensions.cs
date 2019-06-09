using System;
using System.Text;

namespace UnityAtoms.Extensions
{
    internal static class StringExtensions
    {
        public static int ToInt(this string str, int def)
        {
            int num;
            return int.TryParse(str, out num) ? num : def;
        }

        public static string Repeat(this string str, int times)
            => times == 1 ? str : new StringBuilder(str.Length * times).Insert(0, str, times).ToString();
    }
}
