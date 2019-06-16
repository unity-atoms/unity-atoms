using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

namespace UnityAtoms
{
    internal class AtomsIconAssignmentProcessor : IconAssignmentProcessor
    {
        protected override string IconSearchPath
        {
            get => System.Environment.CurrentDirectory.Contains("unity-atoms/UnityAtomsTestsAndExamples") ?
                Directory.GetParent(Directory.GetParent(Application.dataPath).FullName).FullName :
                Directory.GetParent(Application.dataPath).FullName;
        }
        protected override string IconSearchFilter { get => "atom-icon-"; }
        protected override string SettingsPath { get => $"{Application.dataPath}{Path.DirectorySeparatorChar}UnityAtomsIconSettings.json"; }
        protected override List<IIconAssigner> IconAssigners { get => new List<IIconAssigner>() { new AtomMonoScriptAssigner() }; }
    }

    internal class AtomMonoScriptAssigner : IconAssigner<MonoScript>
    {
        protected override Func<MonoScript, List<IconData>, IconData> SelectIcon
        {
            get => (script, icons) =>
            {
                var type = script?.GetClass();
                var scriptName = type?.Name;
                var inUnityAtomsNS = scriptName != null && type != null && type.Namespace != null && type.Namespace.StartsWith("UnityAtoms");
                if (inUnityAtomsNS)
                {
                    if (typeof(IGameActionIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-purple");
                    }
                    else if (typeof(IVariableIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-orange");
                    }
                    else if (typeof(IConstantIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-teal");
                    }
                    else if (typeof(IEventIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-teal");
                    }
                    else if (typeof(IFunctionIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-lush");
                    }
                    else if (typeof(IListenerIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-piglet");
                    }
                    else if (typeof(IListIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-pinky");
                    }
                }

                return null;
            };
        }
    }
}
