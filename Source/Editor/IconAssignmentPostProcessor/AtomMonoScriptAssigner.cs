using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;

namespace UnityAtoms
{
    /// <summary>
    /// Custom icon assigner for Unity Atoms.
    /// </summary>
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
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-lush");
                    }
                    else if (typeof(IConstantIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-teal");
                    }
                    else if (typeof(IEventIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-cherry");
                    }
                    else if (typeof(IFunctionIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-sand");
                    }
                    else if (typeof(IListenerIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-piglet");
                    }
                    else if (typeof(IListIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-orange");
                    }
                    return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-delicate");
                }

                return null;
            };
        }
    }
}
