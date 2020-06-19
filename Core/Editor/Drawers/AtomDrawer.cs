#if UNITY_2018_3_OR_NEWER
using System.Collections.Generic;
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
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), isCreatingSO ? new GUIContent("Name of New Atom") : label);
            GUI.color = defaultGUIColor;

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            if (isCreatingSO)
            {
                drawerData.NameOfNewAtom = EditorGUI.TextField(position, drawerData.NameOfNewAtom);
            }
            else
            {
                property.objectReferenceValue = EditorGUI.ObjectField(position, property.objectReferenceValue, typeof(T), false);
            }

            if (property.objectReferenceValue == null)
            {
                if (isCreatingSO)
                {
                    var buttonWidth = 24;
                    Rect secondButtonRect;
                    Rect firstButtonRect = IMGUIUtils.SnipRectH(restRect, restRect.width - buttonWidth, out secondButtonRect, gutter);
                    if (GUI.Button(firstButtonRect, "✓"))
                    {
                        if (drawerData.NameOfNewAtom.Length > 0)
                        {
                            try
                            {
                                // Create asset
                                T so = ScriptableObject.CreateInstance<T>();
                                AssetDatabase.CreateAsset(so, "Assets/" + drawerData.NameOfNewAtom + ".asset");
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
                        }
                        else
                        {
                            drawerData.WarningText = "Name of new Atom must be specified!";
                        }
                    }
                    if (GUI.Button(secondButtonRect, "✗"))
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
                    }
                }
            }

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();
        }
    }
}
#endif