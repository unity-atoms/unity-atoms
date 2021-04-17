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
        private static Dictionary<string, int> _perPropertyObjectPickerID = new Dictionary<string, int>();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (property.serializedObject.isEditingMultipleObjects)
            {
                EditorGUI.PropertyField(position, property, label, true);
                return;
            }

            EditorGUI.BeginProperty(position, label, property);

            Rect restRect = new Rect();

            if (property.objectReferenceValue == null)
            {
                position = IMGUIUtils.SnipRectH(position, position.width - 58f, out restRect, 6f);
            }

            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

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

            if (property.objectReferenceValue == null)
            {
                if(GUI.Button(restRect, "Create"))
                {
                    var types = GetInstantiateableChildrenTypes();

                    switch(types.Length)
                    {
                        case 0:
                            break;
                        case 1:
                            CreateAtom(types[0]);
                            break;
                        default:
                            var menu = new GenericMenu();
                            foreach (var type in types)
                            {
                                menu.AddItem(new GUIContent(type.Name), false, (data) => CreateAtom((Type)data), type);
                            }

                            menu.DropDown(restRect);
                            break;
                    }

                    void CreateAtom(Type type)
                    {
                        var path = EditorUtility.SaveFilePanelInProject("Choose Atom Location", type.Name, "asset", "Choose a location to store the Atom.");
                        if (!string.IsNullOrEmpty(path))
                        {
                            path = AssetDatabase.GenerateUniqueAssetPath(path);

                            // Create Asset
                            var so = ScriptableObject.CreateInstance(type);

                            AssetDatabase.CreateAsset(so, path);
                            AssetDatabase.SaveAssets();

                            // Assign the newly created so
                            property.objectReferenceValue = so;
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
