using System;

namespace UnityAtoms
{
    /// <summary>
    /// Specify a texture name from your assets that will be assigned as an icon to the MonoBehaviour.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public class AssignIcon : Attribute
    {
        public AssignIcon(string iconName)
        {
            IconName = iconName;
        }

        public string IconName { get; set; }
    }
}
