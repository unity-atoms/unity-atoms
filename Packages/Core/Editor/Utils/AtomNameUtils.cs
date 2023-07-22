using System.Text.RegularExpressions;
using UnityEditor;

namespace UnityAtoms.Editor
{
    public static class AtomNameUtils
    {
        public static string CleanPropertyName(string propertyName)
        {
            string cleanedProperty = propertyName;
            if (Regex.Match(cleanedProperty, @"[a-zA-Z]").Success)
            {
                var index = Regex.Match(cleanedProperty, @"[a-zA-Z]").Index;
                cleanedProperty = cleanedProperty[index].ToString().ToUpper() + cleanedProperty.Substring(index + 1);
            }
            return cleanedProperty;
        }

        public static string CreateUniqueName(string atomName)
        {
            var results = AssetDatabase.FindAssets(atomName);
            return results.Length > 0 ? $"{atomName} ({results.Length})" : atomName;
        }
    }
}

