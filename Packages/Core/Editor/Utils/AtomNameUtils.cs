using System.Text.RegularExpressions;
using UnityEditor;

namespace UnityAtoms.Editor
{
    public static class AtomNameUtils
    {
        public static string FilterLastIndexOf(string result, string identifier)
        {
            return result.Contains(identifier) ? result.Substring(result.LastIndexOf(identifier) + 1) : result;
        }

        public static string CleanPropertyName(string propertyName)
        {
            string cleanedProperty = propertyName;
            if (propertyName[0].ToString() == "_")
            {
                cleanedProperty = propertyName.Substring(1);
            }
            if (Regex.Match(cleanedProperty, @"[a-zA-Z]").Success)
            {
                var index = Regex.Match(cleanedProperty, @"[a-zA-Z]").Index;
                cleanedProperty = cleanedProperty[index].ToString().ToUpper() + cleanedProperty.Substring(index + 1);
            }
            return cleanedProperty;
        }

        public static string CheckForDuplicateAtom(string atomName)
        {
            var results = AssetDatabase.FindAssets(atomName);
            return results.Length > 0 ? $"{atomName} ({results.Length})" : atomName;
        }
    }
}

