using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// The base Unity Atoms property drawer. Makes it possible to create and add a new Atom via Unity's inspector.
    /// </summary>
    [CustomPropertyDrawer(typeof(BaseAtom), true)]
    public class AtomDrawer : PropertyDrawer
    {
        class DrawerData
        {
            public bool UserClickedToCreateAtom = false;
            public string NameOfNewAtom = "";
            public string WarningText = "";
        }

        private const string NAMING_FIELD_CONTROL_NAME = "Naming Field";

        private Dictionary<string, DrawerData> _perPropertyViewData = new Dictionary<string, DrawerData>();
        private static Dictionary<string, int> _perPropertyObjectPickerID = new Dictionary<string, int>();

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
            Rect fuseRect = new Rect();

            if (drawerData.WarningText.Length > 0)
            {
                position = IMGUIUtils.SnipRectV(position, EditorGUIUtility.singleLineHeight, out warningRect, 2f);
            }

            if (property.objectReferenceValue == null)
            {
                position = IMGUIUtils.SnipRectH(position, position.width - restWidth, out restRect, gutter);
            }
            else if (property.GetParent() is BaseAtom ab && AtomFuser.IsValidFuse(ab))
            {
                position = IMGUIUtils.SnipRectH(position, position.width - restWidth, out fuseRect, gutter);
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
                if (fieldInfo.FieldType.IsGenericType)
                {
                    int controlID;

                    var objectPickerButtonRect = new Rect(position);
                    objectPickerButtonRect.x += objectPickerButtonRect.width - 20f;
                    objectPickerButtonRect.width = 20f;

                    if (GUI.Button(objectPickerButtonRect, string.Empty, GUIStyle.none))
                    {
                        var types = GetInstantiateableChildrenTypes();
                        var filter = string.Join(" ", types.Select(type => $"t:{type.Name}"));
                        
                        controlID = GUIUtility.GetControlID(FocusType.Keyboard);
                        EditorGUIUtility.ShowObjectPicker<MonoBehaviour>(property.objectReferenceValue, false, filter, controlID);

                        _perPropertyObjectPickerID[property.propertyPath] = controlID;
                    }

                    if (_perPropertyObjectPickerID.TryGetValue(property.propertyPath, out controlID)
                        && controlID == EditorGUIUtility.GetObjectPickerControlID())
                    {
                        property.objectReferenceValue = EditorGUIUtility.GetObjectPickerObject();
                    }
                }

                EditorGUI.BeginChangeCheck();
                var obj = EditorGUI.ObjectField(position, property.objectReferenceValue, GetAtomEventType(), false);
                if (EditorGUI.EndChangeCheck())
                {
                    if (property.GetParent() is BaseAtom ab)
                    {
                        if (obj == null && AtomFuser.IsFused(property, ab))
                        {
                            AtomFuser.DiffuseAtom(property, ab);
                        }
                        else if (property.objectReferenceValue != null && AtomFuser.IsFused(property, ab))
                        {
                            if (property.objectReferenceValue.name != obj.name)
                            {
                                AtomFuser.DiffuseAtom(property, ab);
                                property.objectReferenceValue = obj;
                                AtomFuser.FuseAtom(property, ab);
                            }
                        }
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
                                var so = ScriptableObject.CreateInstance(GetAtomEventType());
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
                        drawerData.UserClickedToCreateAtom = true;

                        EditorGUI.FocusTextInControl(NAMING_FIELD_CONTROL_NAME);
                        CreateAtomName(property, drawerData);
                    }
                }
            }
            else
            {
                if (property.GetParent() is BaseAtom ab)
                {
                    var subAsset = AtomFuser.FindSubAsset(ab, property.objectReferenceValue);
                    if (subAsset == null)
                    {
                        if (GUI.Button(fuseRect, "Fuse"))
                        {
                            AtomFuser.FuseAtom(property, ab);
                        }
                    }
                    else if (AtomFuser.IsValidFuse(ab))
                    {
                        if (GUI.Button(fuseRect, "Diffuse"))
                        {
                            AtomFuser.DiffuseAtom(property, ab);
                        }
                    }
                }
            }
            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private void CreateAtomName(SerializedProperty property, DrawerData drawerData)
        {
            if (property.GetParent() is BaseAtom atom)
            {
                var atomName = AtomNameUtils.CheckForDuplicateAtom(atom.name + AtomNameUtils.CleanPropertyName(property.name)
                    + AtomNameUtils.FilterLastIndexOf(GetAtomEventType().ToString(), "."));
                drawerData.NameOfNewAtom = atomName;
            }
            else
            {
                var atomName = AtomNameUtils.CheckForDuplicateAtom(AtomNameUtils.CleanPropertyName(property.name)
                    + AtomNameUtils.FilterLastIndexOf(GetAtomEventType().ToString(), "."));
                drawerData.NameOfNewAtom = atomName;
            }
        }

        private Type[] GetInstantiateableChildrenTypes()
        {
            return TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType).ToArray();
        }

        private Type GetAtomEventType()
        {
            if (TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType).Count != 0)
            {
                return TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType).First();
            }
            else
            {
                return TypeCache.GetTypesDerivedFrom(fieldInfo.FieldType.BaseType).First();
            }
        }
    }
}
