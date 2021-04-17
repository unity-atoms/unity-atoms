using System;

namespace UnityAtoms
{
    /// <summary>
    /// Specify a texture name from your assets which you want to be assigned as an icon to the MonoScript.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public class EditorIcon : Attribute
    {
        public EditorIcon(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
