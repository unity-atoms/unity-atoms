using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

namespace UnityAtoms
{
    internal class AttributeIconAssignmentProcessor : IconAssignmentProcessor
    {
        protected override string IconSearchFilter { get => null; }
        protected override string SettingsPath { get => $"{Application.dataPath}{Path.DirectorySeparatorChar}AttributeAssignIconSettings.json"; }
        protected override List<IIconAssigner> IconAssigners { get => new List<IIconAssigner>() { new AttributeMonoScriptAssigner() }; }
    }

    internal class AttributeMonoScriptAssigner : IconAssigner<MonoScript>
    {
        protected override Func<MonoScript, List<IconData>, IconData> SelectIcon
        {
            get => (script, icons) =>
            {
                var type = script?.GetClass();
                if (type != null)
                {
                    var scriptIcon = type.GetCustomAttributes(typeof(ScriptIcon), true).FirstOrDefault() as ScriptIcon;
                    if (scriptIcon != null)
                    {
                        return icons.FirstOrDefault((icon) => icon.Name.Contains(scriptIcon.IconName));
                    }
                }

                return null;
            };
        }
    }
}
