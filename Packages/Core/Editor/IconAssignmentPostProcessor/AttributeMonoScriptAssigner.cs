using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;

namespace UnityAtoms
{
    /// <summary>
    /// Assigner that enables the attribute AssignIcon.
    /// </summary>
    public class AttributeMonoScriptAssigner : IconAssigner<MonoScript>
    {
        protected override Func<MonoScript, List<IconData>, IconData> SelectIcon
        {
            get => (script, icons) =>
            {
                var type = script?.GetClass();
                if (type != null)
                {
                    var assignIcon = type.GetCustomAttributes(typeof(AssignIcon), true).FirstOrDefault() as AssignIcon;
                    if (assignIcon != null)
                    {
                        return icons.FirstOrDefault((icon) => icon.Name.Contains(assignIcon.IconName));
                    }
                }

                return null;
            };
        }
    }
}
