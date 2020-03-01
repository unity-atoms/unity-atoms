#if UNITY_2018_4_OR_NEWER
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Internal utility class to regenerate all Atoms. Reachable via top menu bar and `Tools/Unity Atoms/Regenerate All Atoms`.
    /// </summary>
    internal class RegenereateAllAtoms
    {
        private class RegenerateItem
        {
            public string ValueType { get; set; }
            public string BaseWritePath { get; set; }
            public bool IsValueEquatable { get; set; }
            public List<AtomType> AtomTypesToGenerate { get; set; }
            public string ValueTypeNamespace { get; set; }
            public string SubUnityAtomsNamespace { get; set; }

            public RegenerateItem(string valueType, string baseWritePath, bool isValueEquatable, List<AtomType> atomTypesToGenerate, string typeNamespace, string subUnityAtomsNamespace)
            {
                this.ValueType = valueType;
                this.BaseWritePath = baseWritePath;
                this.IsValueEquatable = isValueEquatable;
                this.AtomTypesToGenerate = atomTypesToGenerate;
                this.ValueTypeNamespace = typeNamespace;
                this.SubUnityAtomsNamespace = subUnityAtomsNamespace;
            }
        }

        /// <summary>
        /// Create the editor window.
        /// </summary>
        [MenuItem("Tools/Unity Atoms/Regenerate all Atoms")]
        static void Regenereate()
        {
            if (!Runtime.IsUnityAtomsRepo)
            {
                Debug.LogWarning("This is currently only available working in the Unity Atoms project...");
            }

            string path = EditorUtility.OpenFolderPanel("Select the 'Packages' folder (containing Core)", ".", "");
            if (string.IsNullOrEmpty(path))
            {
                Debug.LogWarning("Empty path. Abort.");
                return;
            }
            path = new Uri(Application.dataPath).MakeRelativeUri(new Uri(path)).ToString();

            var i = EditorUtility.DisplayDialogComplex("Regenerate Atoms",
                $"Do you want to regenerate all Atoms and write them to '{path}'?\n",
                "Yes, I know what I'm doing!", "Cancel", "");

            if (i == 1)
            {
                Debug.LogWarning("Cancelled generating Atoms.");
                return;
            }

            var itemsToRegenerate = new List<RegenerateItem>()
            {
                // new RegenerateItem(valueType: "bool", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "Collider2D", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: false, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "Collider", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: false, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "Color", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "float", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "GameObject", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: false, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(valueType: "int", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "string", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "Vector2", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                // new RegenerateItem(valueType: "Vector3", baseWritePath: Path.Combine(path, "Core"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                // new RegenerateItem(
                //     valueType: "AtomBaseVariable",
                //     baseWritePath: Path.Combine(path, "Core"),
                //     isValueEquatable: false,
                //     atomTypesToGenerate: new List<AtomType>() { AtomTypes.EVENT, AtomTypes.ACTION, AtomTypes.UNITY_EVENT, AtomTypes.EVENT_LISTENER },
                //     typeNamespace: "",
                //     subUnityAtomsNamespace: ""
                // ),
                // new RegenerateItem(valueType: "TouchUserInput", baseWritePath: Path.Combine(path, "Mobile"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.Mobile", subUnityAtomsNamespace: "Mobile"),
                // new RegenerateItem(valueType: "SceneField", baseWritePath: Path.Combine(path, "SceneMgmt"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.SceneMgmt", subUnityAtomsNamespace: "SceneMgmt"),
            };


            foreach (var item in itemsToRegenerate)
            {
                var templates = Generator.GetTemplatePaths();
                var templateConditions = Generator.CreateTemplateConditions(item.IsValueEquatable, item.ValueTypeNamespace, item.SubUnityAtomsNamespace);
                var templateVariables = Generator.CreateTemplateVariablesMap(item.ValueType, item.ValueTypeNamespace, item.SubUnityAtomsNamespace);
                var capitalizedValueType = item.ValueType.Capitalize();

                var atomTypesToGenerate = item.AtomTypesToGenerate;
                foreach (var atomType in atomTypesToGenerate)
                {
                    templateVariables["VALUE_TYPE_NAME"] = atomType.IsValuePair ? $"{capitalizedValueType}Pair" : capitalizedValueType;
                    var valueType = atomType.IsValuePair ? $"{capitalizedValueType}Pair" : item.ValueType;
                    templateVariables["VALUE_TYPE"] = valueType;
                    Generator.Generate(new AtomReceipe(atomType, valueType), item.BaseWritePath, templates, templateConditions, templateVariables);
                }
            }
            AssetDatabase.Refresh();
        }

    }
}
#endif