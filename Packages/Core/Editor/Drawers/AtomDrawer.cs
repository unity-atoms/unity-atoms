using System;
using System.Collections.Generic;
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

        private static Dictionary<string, int> _perPropertyObjectPickerID = new Dictionary<string, int>();

        private Dictionary<string, DrawerData> _perPropertyViewData = new Dictionary<string, DrawerData>();
        private Type selectedType;

        // TODO: Find a more elegant solution that doesn't require the focusText value.
        private bool focusText = false;

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

            if (drawerData.WarningText.Length > 0)
            {
                position = IMGUIUtils.SnipRectV(position, EditorGUIUtility.singleLineHeight, out warningRect, 2f);
            }

            if (property.objectReferenceValue == null)
            {
                position = IMGUIUtils.SnipRectH(position, position.width - restWidth, out restRect, gutter);
            }

            var defaultGUIColor = GUI.color;
            GUI.color = isCreatingSO ? Color.yellow : defaultGUIColor;
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), isCreatingSO && label != GUIContent.none ? new GUIContent("Name of New Atom") : label);
            GUI.color = defaultGUIColor;

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            GUI.SetNextControlName(NAMING_FIELD_CONTROL_NAME);
            drawerData.NameOfNewAtom = EditorGUI.TextField(isCreatingSO ? position : Rect.zero, drawerData.NameOfNewAtom);

            if(isCreatingSO)
            {
                if(focusText)
                {
                    EditorGUI.FocusTextInControl(NAMING_FIELD_CONTROL_NAME);
                    focusText = false;
                }
            }
            else
            {
                if(fieldInfo.FieldType.IsGenericType)
                {
                    int controlID;

                    var objectPickerButtonRect = new Rect(position);
                    objectPickerButtonRect.x += objectPickerButtonRect.width - 20f;
                    objectPickerButtonRect.width = 20f;

                    if(GUI.Button(objectPickerButtonRect, string.Empty, GUIStyle.none))
                    {
                        var types = GetInstantiateableChildrenTypes();
                        var filter = string.Join(" ", types.Select(type => $"t:{type.Name}"));

                        controlID = GUIUtility.GetControlID(FocusType.Keyboard);
                        EditorGUIUtility.ShowObjectPicker<MonoBehaviour>(property.objectReferenceValue, false, filter, controlID);

                        _perPropertyObjectPickerID[property.propertyPath] = controlID;
                    }

                    if(_perPropertyObjectPickerID.TryGetValue(property.propertyPath, out controlID)
                        && controlID == EditorGUIUtility.GetObjectPickerControlID())
                    {
                        property.objectReferenceValue = EditorGUIUtility.GetObjectPickerObject();
                    }
                }

                property.objectReferenceValue = EditorGUI.ObjectField(position, property.objectReferenceValue, fieldInfo.FieldType, false);
            }

            if (property.objectReferenceValue == null)
            {
                if (isCreatingSO)
                {
                    var buttonWidth = 24;
                    Rect secondButtonRect;
                    Rect firstButtonRect = IMGUIUtils.SnipRectH(restRect, restRect.width - buttonWidth, out secondButtonRect, gutter);
                    if (GUI.Button(firstButtonRect, "✓")
                        || Event.current.keyCode == KeyCode.Return)
                    {
                        if (drawerData.NameOfNewAtom.Length > 0)
                        {
                            try
                            {
                                // Create asset
                                var so = ScriptableObject.CreateInstance(selectedType);
                                var assetPath = "Assets/" + drawerData.NameOfNewAtom + ".asset";
                                var uniqueAssetPath = AssetDatabase.GenerateUniqueAssetPath(assetPath);
                                AssetDatabase.CreateAsset(so, uniqueAssetPath);
                                AssetDatabase.SaveAssets();
                                // Assign the newly created SO
                                property.objectReferenceValue = so;
                            }
                            catch
                            {
                                Debug.LogError("Not able to create Atom");
                            }

                            drawerData.UserClickedToCreateAtom = false;
                            drawerData.WarningText = "";
                            selectedType = null;
                        }
                        else
                        {
                            drawerData.WarningText = "Name of new Atom must be specified!";
                            EditorGUI.FocusTextInControl(NAMING_FIELD_CONTROL_NAME);
                        }
                    }
                    if (GUI.Button(secondButtonRect, "✗")
                        || Event.current.keyCode == KeyCode.Escape)
                    {
                        drawerData.UserClickedToCreateAtom = false;
                        drawerData.WarningText = "";
                        selectedType = null;
                    }

                    if (drawerData.WarningText.Length > 0)
                    {
                        EditorGUI.HelpBox(warningRect, drawerData.WarningText, MessageType.Warning);
                    }
                }
                else
                {
                    if(GUI.Button(restRect, "Create"))
                    {
                        if(!fieldInfo.FieldType.IsGenericType
                            && fieldInfo.FieldType.IsSealed)
                        {
                            OnTypeSelected(fieldInfo.FieldType);
                        }
                        else
                        {
                            var types = GetInstantiateableChildrenTypes();

                            if(types.Length == 1)
                            {
                                OnTypeSelected(types[0]);
                            }

                            if(types.Length > 1)
                            {
                                var menu = new GenericMenu();
                                for(int i = 0; i < types.Length; i++)
                                {
                                    var type = types[i];

                                    menu.AddItem(new GUIContent(type.Name), false, OnTypeSelected, type);
                                }

                                menu.DropDown(restRect);
                            }
                        }

                        void OnTypeSelected(object type)
                        {
                            selectedType = (Type)type;
                            drawerData.NameOfNewAtom = "";
                            drawerData.UserClickedToCreateAtom = true;

                            EditorGUI.FocusTextInControl(NAMING_FIELD_CONTROL_NAME);
                            focusText = true;
                        }
                    }
                }
            }

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }

        private Type[] GetInstantiateableChildrenTypes()
        {
            return (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                    from type in assembly.GetTypes()
                    where !type.IsAbstract
                    where !type.IsGenericType
                    where type == fieldInfo.FieldType || type.IsSubclassOf(fieldInfo.FieldType)
                    select type).ToArray();
        }
    }
}
