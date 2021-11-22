#if UNITY_2018_3_OR_NEWER
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// The base Unity Atoms property drawer. Makes it possible to create and add a new Atom via Unity's inspector. Only availble in `UNITY_2018_3_OR_NEWER`.
    /// </summary>
    /// <typeparam name="T">The type of Atom the property drawer should apply to.</typeparam>
    public abstract class AtomDrawer<T> : PropertyDrawer where T : ScriptableObject
    {
        class DrawerData
        {
            public bool UserClickedToCreateAtom = false;
            public string NameOfNewAtom = "";
            public string WarningText = "";
        }

        private const string NAMING_FIELD_CONTROL_NAME = "Naming Field";

        private Dictionary<string, DrawerData> _perPropertyViewData = new Dictionary<string, DrawerData>();

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject.isEditingMultipleObjects)
            {
                return EditorGUI.GetPropertyHeight(property);
            }

            DrawerData drawerData = GetDrawerData(property.propertyPath);
            var isCreatingSO = drawerData.UserClickedToCreateAtom && property.objectReferenceValue == null;
            if (!isCreatingSO || drawerData.WarningText.Length <= 0) return base.GetPropertyHeight(property, label);
            return base.GetPropertyHeight(property, label) * 2 + 4f;
        }

        private DrawerData GetDrawerData(string propertyPath)
        {
            DrawerData drawerData;
            if (!_perPropertyViewData.TryGetValue(propertyPath, out drawerData))
            {
                drawerData = new DrawerData();
                _perPropertyViewData[propertyPath] = drawerData;
            }
            return drawerData;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject.isEditingMultipleObjects)
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }

            EditorGUI.BeginProperty(position, label, property);

            DrawerData drawerData = GetDrawerData(property.propertyPath);

            var isCreatingSO = drawerData.UserClickedToCreateAtom && property.objectReferenceValue == null;
            var restWidth = drawerData.UserClickedToCreateAtom ? 50 : 58;
            var gutter = drawerData.UserClickedToCreateAtom ? 2f : 6f;
            Rect restRect = new Rect();
            Rect warningRect = new Rect();
            Rect nestRect = new Rect();

            if (drawerData.WarningText.Length > 0)
            {
                position = IMGUIUtils.SnipRectV(position, EditorGUIUtility.singleLineHeight, out warningRect, 2f);
            }

            if (property.objectReferenceValue == null)
            {
                position = IMGUIUtils.SnipRectH(position, position.width - restWidth, out restRect, gutter);
            }
            else if(property.GetParent() is BaseAtom ab && IsValidFuse(ab))
            {
                position = IMGUIUtils.SnipRectH(position, position.width - restWidth, out nestRect, gutter);
            }

            var defaultGUIColor = GUI.color;
            GUI.color = isCreatingSO ? Color.yellow : defaultGUIColor;
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), isCreatingSO && label != GUIContent.none ? new GUIContent("Name of New Atom") : label);
            GUI.color = defaultGUIColor;

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            GUI.SetNextControlName(NAMING_FIELD_CONTROL_NAME);
            drawerData.NameOfNewAtom = EditorGUI.TextField(isCreatingSO ? position : Rect.zero, drawerData.NameOfNewAtom);

            if (!isCreatingSO)
            {
                EditorGUI.BeginChangeCheck();
                var obj = EditorGUI.ObjectField(position, property.objectReferenceValue, typeof(T), false);
                if (EditorGUI.EndChangeCheck())
                {
                    if(obj == null && property.GetParent() is BaseAtom ab && IsFused(property, ab))
                    {
                        DiffuseAtom(property, ab, drawerData);
                    }
                    property.objectReferenceValue = obj;
                }
            }

            if (property.objectReferenceValue == null)
            {
                if (isCreatingSO)
                {
                    var buttonWidth = 24;
                    Rect secondButtonRect;
                    Rect firstButtonRect = IMGUIUtils.SnipRectH(restRect, restRect.width - buttonWidth, out secondButtonRect, gutter);
                    if (GUI.Button(firstButtonRect, "✓")
                        || (Event.current.keyCode == KeyCode.Return
                            && GUI.GetNameOfFocusedControl() == NAMING_FIELD_CONTROL_NAME))
                    {
                        if (drawerData.NameOfNewAtom.Length > 0)
                        {
                            try
                            {
                                string path = AssetDatabase.GetAssetPath(property.serializedObject.targetObject);
                                path = path == "" ? "Assets/" : Path.GetDirectoryName(path) + "/";
                                // Create asset
                                T so = ScriptableObject.CreateInstance<T>();

                                //property.objectReferenceValue = so;
                                if (property.GetParent() is BaseAtom ab)
                                {
                                    so.name = drawerData.NameOfNewAtom;
                                    AssetDatabase.AddObjectToAsset(so, ab);
                                    AssetDatabase.SaveAssets();
                                    AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(ab));
                                    AssetDatabase.ImportAsset(AssetDatabase.GetAssetPath(so));
                                    property.objectReferenceValue = so;
                                }
                                else
                                {
                                    AssetDatabase.CreateAsset(so, path + drawerData.NameOfNewAtom + ".asset");
                                    AssetDatabase.SaveAssets();
                                    property.objectReferenceValue = so;
                                }
                            }
                            catch
                            {
                                Debug.LogError("Not able to create Atom");
                            }

                            drawerData.UserClickedToCreateAtom = false;
                            drawerData.WarningText = "";
                        }
                        else
                        {
                            drawerData.WarningText = "Name of new Atom must be specified!";
                            EditorGUI.FocusTextInControl(NAMING_FIELD_CONTROL_NAME);
                        }
                    }
                    if (GUI.Button(secondButtonRect, "✗")
                        || (Event.current.keyCode == KeyCode.Escape
                            && GUI.GetNameOfFocusedControl() == NAMING_FIELD_CONTROL_NAME))
                    {
                        drawerData.UserClickedToCreateAtom = false;
                        drawerData.WarningText = "";
                    }

                    if (drawerData.WarningText.Length > 0)
                    {
                        EditorGUI.HelpBox(warningRect, drawerData.WarningText, MessageType.Warning);
                    }
                }
                else
                {
                    if (GUI.Button(restRect, "Create"))
                    {
                        drawerData.NameOfNewAtom = "";
                        drawerData.UserClickedToCreateAtom = true;

                        EditorGUI.FocusTextInControl(NAMING_FIELD_CONTROL_NAME);
                    }
                }
            }
            else 
            {
                if (property.GetParent() is BaseAtom ab)
                {
                    var x = FindSubAsset(ab, property.objectReferenceValue);
                    if (x == null)
                    {
                        if (GUI.Button(nestRect, "Fuse"))
                        {
                            FuseAtom(property, ab, drawerData);
                        }
                    }
                    else if(IsValidFuse(ab))
                    {
                        if (GUI.Button(nestRect, "Diffuse"))
                        {
                            DiffuseAtom(property, ab, drawerData);
                        }
                    }
                }                
            }
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private static void FuseAtom(SerializedProperty property, BaseAtom ab, DrawerData drawerData)
        {
            var sourceIsMain = AssetDatabase.IsMainAsset(property.objectReferenceValue);
            var sourcePath = AssetDatabase.GetAssetPath(property.objectReferenceValue);
            AssetDatabase.RemoveObjectFromAsset(property.objectReferenceValue);
            AssetDatabase.AddObjectToAsset(property.objectReferenceValue, ab);

            if (sourceIsMain)
                AssetDatabase.DeleteAsset(sourcePath);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private static void DiffuseAtom(SerializedProperty property, BaseAtom ab, DrawerData drawerData)
        {
            var variablePath = AssetDatabase.GetAssetOrScenePath(ab);
            var destinationPath = variablePath.Replace($"/{ab.name}.asset", "");
            var assetName = property.objectReferenceValue.name + ".asset";
            var assetPath = Path.Combine(destinationPath, assetName);
            var assetUniquePath = AssetDatabase.GenerateUniqueAssetPath(assetPath);
            AssetDatabase.RemoveObjectFromAsset(property.objectReferenceValue);
            AssetDatabase.CreateAsset(property.objectReferenceValue, assetUniquePath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private Object FindSubAsset(Object asset, Object assetToFind)
        {
            Object[] objs = AssetDatabase.LoadAllAssetsAtPath(AssetDatabase.GetAssetPath(asset));
            foreach (var item in objs)
            {
                if(assetToFind.Equals(item))
                {
                    return item;
                }
            }
            return default;
        }

        private bool IsValidFuse(BaseAtom ab)
        {
            var variablePath = AssetDatabase.GetAssetOrScenePath(ab);
            var destinationPath = variablePath.Replace($"/{ab.name}.asset", "");
            if (destinationPath.Contains(".asset"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsFused(SerializedProperty property, BaseAtom ab)
        {
            if(FindSubAsset(ab, property.objectReferenceValue) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
#endif
