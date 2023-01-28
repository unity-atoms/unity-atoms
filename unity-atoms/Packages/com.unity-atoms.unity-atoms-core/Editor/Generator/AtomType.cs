using System;
using System.Text.RegularExpressions;
using System.IO;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal module class that holds that regarding an Atom type.
    /// </summary>
    internal struct AtomType : IEquatable<AtomType>
    {
        public string DisplayName { get; set; }
        public string Name { get; set; }
        public string TemplateName { get; set; }
        public string RelativeFileNameAndPath { get; set; }
        public string DrawerTemplateName { get; set; }
        public string RelativeDrawerFileNameAndPath { get; set; }
        public string EditorTemplateName { get; set; }
        public string RelativeEditorFileNameAndPath { get; set; }
        public bool IsValuePair { get; set; }

        private static string CreateRelativeFilePath(string atomName) => Path.Combine(Runtime.IsUnityAtomsRepo ? "Runtime" : "", $"{atomName}s", $"{{VALUE_TYPE_NAME}}{atomName}.cs");
        private static string CreateRelativeDrawerPath(string atomName) => Path.Combine("Editor", Runtime.IsUnityAtomsRepo ? "Drawers" : "AtomDrawers", $"{atomName}s", $"{{VALUE_TYPE_NAME}}{atomName}Drawer.cs");
        private static string CreateEditorDrawerPath(string atomName) => Path.Combine("Editor", Runtime.IsUnityAtomsRepo ? "Editors" : "AtomEditors", $"{atomName}s", $"{{VALUE_TYPE_NAME}}{atomName}Editor.cs");

        public AtomType(
            string displayName,
            string templateName,
            string name = "",
            string relativeFileNameAndPath = "",
            string drawerTemplateName = "",
            string relativeDrawerFileNameAndPath = "",
            string editorTemplateName = "",
            string relativeEditorFileNameAndPath = ""
        )
        {
            this.DisplayName = displayName;
            this.TemplateName = templateName;
            this.Name = string.IsNullOrEmpty(name) ? Regex.Replace(displayName, @"\s+", "") : name;
            this.RelativeFileNameAndPath = string.IsNullOrEmpty(relativeFileNameAndPath) ? CreateRelativeFilePath(this.Name) : relativeFileNameAndPath;
            this.DrawerTemplateName = drawerTemplateName;
            this.RelativeDrawerFileNameAndPath = string.IsNullOrEmpty(relativeDrawerFileNameAndPath) ? CreateRelativeDrawerPath(this.Name) : relativeDrawerFileNameAndPath;
            this.EditorTemplateName = editorTemplateName;
            this.RelativeEditorFileNameAndPath = string.IsNullOrEmpty(relativeEditorFileNameAndPath) ? CreateEditorDrawerPath(this.Name) : relativeEditorFileNameAndPath;
            this.IsValuePair = this.DisplayName != "Pair" && this.DisplayName.Contains("Pair");
        }

        public bool HasDrawerTemplate => !string.IsNullOrWhiteSpace(DrawerTemplateName);
        public bool HasEditorTemplate => !string.IsNullOrWhiteSpace(EditorTemplateName);

        public bool Equals(AtomType other)
        {
            return this.Name == other.Name && this.IsValuePair == other.IsValuePair;
        }

        public override bool Equals(object obj)
        {
            return Equals((AtomType)obj);
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + this.Name.GetHashCode();
            hash = hash * 23 + this.IsValuePair.GetHashCode();
            return hash;
        }
    }
}
