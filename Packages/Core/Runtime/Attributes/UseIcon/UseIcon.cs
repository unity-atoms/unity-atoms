using System;

namespace UnityAtoms
{
    /// <summary>
    /// Specify a texture name from your assets which you want to be assigned as an icon to the MonoScript.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public class UseIcon : Attribute
    {
        public UseIcon(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
