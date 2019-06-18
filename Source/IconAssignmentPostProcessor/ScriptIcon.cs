using System;

namespace UnityAtoms
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public class ScriptIcon : Attribute
    {
        public ScriptIcon(string iconName)
        {
            IconName = iconName;
        }

        public string IconName { get; set; }
    }
}
