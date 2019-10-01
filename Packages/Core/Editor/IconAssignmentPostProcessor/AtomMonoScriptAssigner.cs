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
                    if (typeof(IAtomActionIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-purple");
                    }
                    else if (typeof(IAtomVariableIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-lush");
                    }
                    else if (typeof(IAtomConstantIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-teal");
                    }
                    else if (typeof(IAtomEventIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-cherry");
                    }
                    else if (typeof(IAtomFunctionIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-sand");
                    }
                    else if (typeof(IAtomListenerIcon).IsAssignableFrom(type))
                    {
                        return icons.FirstOrDefault((icon) => icon.Name == "atom-icon-piglet");
                    }
                    else if (typeof(IAtomListIcon).IsAssignableFrom(type))
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
