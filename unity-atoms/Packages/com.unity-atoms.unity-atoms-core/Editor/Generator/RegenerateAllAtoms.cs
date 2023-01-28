#if UNITY_2018_3_OR_NEWER
using System;
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

        [MenuItem("Tools/Unity Atoms/Regenerate Atoms from Assets")]
        static void RegenereateAssets()
        {
            if (!EditorUtility.DisplayDialog("Regenerate", "This will regenerate all Atoms from Generation-Assets",
                "Ok", "Cancel"))
            {
                return;
            }

            var guids = AssetDatabase.FindAssets($"t:{nameof(AtomGenerator)}");
            foreach (var guid in guids)
            {
                var path = AssetDatabase.GUIDToAssetPath(guid);
                AssetDatabase.LoadAssetAtPath<AtomGenerator>(path).Generate();
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
                // Base Atoms
                new RegenerateItem(
                    valueType: "Void",
                    baseWritePath: Path.Combine(path, "BaseAtoms"),
                    isValueEquatable: false,
                    atomTypesToGenerate: new List<AtomType>() { AtomTypes.EVENT, AtomTypes.UNITY_EVENT, AtomTypes.BASE_EVENT_REFERENCE, AtomTypes.EVENT_INSTANCER, AtomTypes.BASE_EVENT_REFERENCE_LISTENER },
                    typeNamespace: "",
                    subUnityAtomsNamespace: "BaseAtoms"
                ),
                new RegenerateItem(valueType: "bool", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Collider2D", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: false, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Collider", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: false, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Collision2D", baseWritePath : Path.Combine (path, "BaseAtoms"), isValueEquatable : false, atomTypesToGenerate : AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Collision", baseWritePath : Path.Combine (path, "BaseAtoms"), isValueEquatable : false, atomTypesToGenerate : AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Color", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "float", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "GameObject", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: false, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "int", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "string", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Vector2", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(valueType: "Vector3", baseWritePath: Path.Combine(path, "BaseAtoms"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: "BaseAtoms"),
                new RegenerateItem(
                    valueType: "AtomBaseVariable",
                    baseWritePath: Path.Combine(path, "BaseAtoms"),
                    isValueEquatable: false,
                    atomTypesToGenerate: new List<AtomType>() { AtomTypes.EVENT, AtomTypes.ACTION, AtomTypes.UNITY_EVENT, AtomTypes.BASE_EVENT_REFERENCE, AtomTypes.EVENT_INSTANCER, AtomTypes.BASE_EVENT_REFERENCE_LISTENER },
                    typeNamespace: "",
                    subUnityAtomsNamespace: "BaseAtoms"
                ),

                new RegenerateItem
                (
                    valueType: "double",
                    baseWritePath: Path.Combine(path, "BaseAtoms"),
                    isValueEquatable: true,
                    atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES,
                    typeNamespace: "",
                    subUnityAtomsNamespace: "BaseAtoms"
                ),

                new RegenerateItem
                (
                    valueType: "Quaternion",
                    baseWritePath: Path.Combine(path, "BaseAtoms"),
                    isValueEquatable: true,
                    atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES,
                    typeNamespace: "UnityEngine",
                    subUnityAtomsNamespace: "BaseAtoms"
                ),

                //MonoHooks
                new RegenerateItem(valueType: "ColliderGameObject", baseWritePath: Path.Combine(path, "MonoHooks"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.MonoHooks", subUnityAtomsNamespace: "MonoHooks"),
                new RegenerateItem(valueType: "Collider2DGameObject", baseWritePath: Path.Combine(path, "MonoHooks"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.MonoHooks", subUnityAtomsNamespace: "MonoHooks"),
                new RegenerateItem(valueType: "CollisionGameObject", baseWritePath: Path.Combine(path, "MonoHooks"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.MonoHooks", subUnityAtomsNamespace: "MonoHooks"),
                new RegenerateItem(valueType: "Collision2DGameObject", baseWritePath: Path.Combine(path, "MonoHooks"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.MonoHooks", subUnityAtomsNamespace: "MonoHooks"),

                //Mobile
                new RegenerateItem(valueType: "TouchUserInput", baseWritePath: Path.Combine(path, "Mobile"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.Mobile", subUnityAtomsNamespace: "Mobile"),

                //SceneMgmt
                new RegenerateItem(valueType: "SceneField", baseWritePath: Path.Combine(path, "SceneMgmt"), isValueEquatable: true, atomTypesToGenerate: AtomTypes.ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.SceneMgmt", subUnityAtomsNamespace: "SceneMgmt"),

                //FSM
                new RegenerateItem(
                    valueType: "FSMTransitionData",
                    baseWritePath: Path.Combine(path, "FSM"),
                    isValueEquatable: false,
                    atomTypesToGenerate: new List<AtomType>() { AtomTypes.EVENT, AtomTypes.ACTION, AtomTypes.UNITY_EVENT, AtomTypes.BASE_EVENT_REFERENCE, AtomTypes.EVENT_INSTANCER, AtomTypes.BASE_EVENT_REFERENCE_LISTENER },
                    typeNamespace: "",
                    subUnityAtomsNamespace: "FSM"
                ),

                //Input System
                new RegenerateItem
                (
                    valueType: "PlayerInput",
                    baseWritePath: Path.Combine(path, "InputSystem"),
                    isValueEquatable: false,
                    atomTypesToGenerate: new List<AtomType>()
                    { AtomTypes.EVENT, AtomTypes.ACTION, AtomTypes.UNITY_EVENT, AtomTypes.EVENT_INSTANCER },
                    typeNamespace: "UnityEngine.InputSystem",
                    subUnityAtomsNamespace: "InputSystem"
                ),

                new RegenerateItem
                (
                    valueType: "InputAction.CallbackContext",
                    baseWritePath: Path.Combine(path, "InputSystem"),
                    isValueEquatable: false,
                    atomTypesToGenerate: new List<AtomType>()
                    { AtomTypes.EVENT, AtomTypes.ACTION, AtomTypes.UNITY_EVENT, AtomTypes.EVENT_INSTANCER },
                    typeNamespace: "UnityEngine.InputSystem",
                    subUnityAtomsNamespace: "InputSystem"
                ),
            };

            foreach (var item in itemsToRegenerate)
            {
                var templates = Generator.GetTemplatePaths();
                var templateConditions = Generator.CreateTemplateConditions(item.IsValueEquatable, item.ValueTypeNamespace, item.SubUnityAtomsNamespace, item.ValueType);
                var templateVariables = Generator.CreateTemplateVariablesMap(item.ValueType, item.ValueTypeNamespace, item.SubUnityAtomsNamespace);
                var capitalizedValueType = item.ValueType.Replace('.', '_').Capitalize();

                foreach (var atomType in item.AtomTypesToGenerate)
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
