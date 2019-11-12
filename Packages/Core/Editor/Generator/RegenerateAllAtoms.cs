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
            public string type;
            public string baseWritePath;
            public bool isEquatable;
            public List<AtomType> atomTypesToGenerate;
            public string typeNamespace;
            public string subUnityAtomsNamespace;

            public RegenerateItem(string type, string baseWritePath, bool isEquatable, List<AtomType> atomTypesToGenerate, string typeNamespace, string subUnityAtomsNamespace)
            {
                this.type = type;
                this.baseWritePath = baseWritePath;
                this.isEquatable = isEquatable;
                this.atomTypesToGenerate = atomTypesToGenerate;
                this.typeNamespace = typeNamespace;
                this.subUnityAtomsNamespace = subUnityAtomsNamespace;
            }
        }

        private Generator generator;

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

            string path = EditorUtility.OpenFolderPanel("Select 'Packages' folder (containing Core)", ".", "");
            if (string.IsNullOrEmpty(path))
            {
                Debug.LogWarning("Empty path. Abort.");
                return;
            }
            // make path relative:
            path = new Uri(Application.dataPath).MakeRelativeUri(new Uri(path)).ToString();

            var i = EditorUtility.DisplayDialogComplex("Is UnityAtoms Repository?",
                "Should the files be generated, like in the UnityAtoms Repository?\n"+path,
                "yes, i know what I'm doing", "cancel", "no");

            if(i == 1)
            {
                Debug.LogWarning("Empty path. Abort.");
                return;
            }

            Runtime.IsUnityAtomsRepo = i == 0;

            List<AtomType> ALL_ATOM_TYPES = new List<AtomType>()
            {
                AtomTypes.ACTION,
                AtomTypes.ACTION_X2,
                AtomTypes.CONSTANT,
                AtomTypes.EVENT,
                AtomTypes.EVENT_X2,
                AtomTypes.LIST,
                AtomTypes.LISTENER,
                AtomTypes.LISTENER_X2,
                AtomTypes.REFERENCE,
                AtomTypes.SET_VARIABLE_VALUE,
                AtomTypes.UNITY_EVENT,
                AtomTypes.UNITY_EVENT_X2,
                AtomTypes.VARIABLE
            };



            var itemsToRegenerate = new List<RegenerateItem>()
            {
                new RegenerateItem(type: "bool", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "Collider2D", baseWritePath: Path.Combine(path, "Core"), isEquatable: false, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "Collider", baseWritePath: Path.Combine(path, "Core"), isEquatable: false, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "Color", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "float", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "GameObject", baseWritePath: Path.Combine(path, "Core"), isEquatable: false, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "int", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "string", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "Vector2", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "Vector3", baseWritePath: Path.Combine(path, "Core"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityEngine", subUnityAtomsNamespace: ""),
                new RegenerateItem(type: "TouchUserInput", baseWritePath: Path.Combine(path, "Mobile"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.Mobile", subUnityAtomsNamespace: "Mobile"),
                new RegenerateItem(type: "SceneField", baseWritePath: Path.Combine(path, "SceneMgmt"), isEquatable: true, atomTypesToGenerate: ALL_ATOM_TYPES, typeNamespace: "UnityAtoms.SceneMgmt", subUnityAtomsNamespace: "SceneMgmt"),
            };

            var generator = new Generator();
            foreach (var item in itemsToRegenerate)
            {
                generator.Generate(item.type, item.baseWritePath, item.isEquatable, item.atomTypesToGenerate, item.typeNamespace, item.subUnityAtomsNamespace);
            }
        }

    }
}
