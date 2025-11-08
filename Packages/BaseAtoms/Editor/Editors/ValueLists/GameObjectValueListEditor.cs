using UnityAtoms.BaseAtoms;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

namespace UnityAtoms.Editor
{

    [CustomEditor(typeof(GameObjectValueList))]
    public class GameObjectValueListEditor : UnityEditor.Editor
    {
        ReorderableList _list;

        private void OnEnable()
        {
            InitList();

            // register on playmode state change to clear the list / redraw:
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private void InitList()
        {
            _list = new ReorderableList(serializedObject, serializedObject.FindProperty("list"), true, true, true, true);
            _list.drawHeaderCallback = (Rect rect) =>
            {
                EditorGUI.LabelField(rect, serializedObject.FindProperty("list").displayName);
            };
            _list.drawElementCallback = (Rect rect, int index, bool isActive, bool isFocused) =>
            {
                var element = _list.serializedProperty.GetArrayElementAtIndex(index);
                if (element.objectReferenceValue == null)
                {
                    EditorGUI.PropertyField(rect, element, GUIContent.none);
                    return;
                }
                rect.y += 2;
                rect.height -= 4;

                var objectRef = element.objectReferenceValue;
                var objectName = objectRef ? objectRef.name : "None (GameObject)";
                var icon = EditorGUIUtility.ObjectContent(objectRef, typeof(GameObject)).image;

                // Reserve space for the picker button on the right
                float pickerWidth = 18f;
                var pickerRect = new Rect(rect.xMax - pickerWidth, rect.y, pickerWidth, rect.height);

                // Reserve space for the icon on the left
                float iconSize = rect.height;
                var iconRect = new Rect(rect.x+4, rect.y+2, iconSize, iconSize-4);

                // Text button area (excluding icon and picker)
                float textPadding = 4f;
                var textRect = new Rect(rect.x + iconSize + textPadding, rect.y, rect.width - iconSize - pickerWidth - 2 * textPadding, rect.height);

                // Picker button (mimics the small circle at the end)
                if (GUI.Button(pickerRect, GUIContent.none, "buttonRight"))
                {
                    EditorGUIUtility.ShowObjectPicker<GameObject>(objectRef, true, "", GUIUtility.GetControlID(FocusType.Passive));
                }

                // Draw button styled like ObjectField
                Rect objectFieldButtonRect = new Rect(rect.x, rect.y, rect.width - 2, rect.height);
                if (GUI.Button(objectFieldButtonRect, GUIContent.none, "IN ObjectField"))
                {
                    if (objectRef != null)
                        EditorGUIUtility.PingObject(objectRef);
                }

                Rect objectFieldRect = new Rect(rect.x, rect.y, rect.width - pickerWidth, rect.height);
                GUI.Label(objectFieldRect, GUIContent.none, EditorStyles.objectField);

                if (icon != null) GUI.DrawTexture(iconRect, icon, ScaleMode.ScaleToFit);
                GUI.Label(textRect, objectName);


                // Handle selection from picker
                if (Event.current.commandName == "ObjectSelectorUpdated")
                {
                    var picked = EditorGUIUtility.GetObjectPickerObject();
                    if (picked != element.objectReferenceValue)
                    {
                        element.objectReferenceValue = picked;
                        GUI.changed = true;
                        serializedObject.ApplyModifiedProperties();
                    }
                }

                // this custom drag and drop logic still allows only asset-references to be dragged and dropped
                if (objectFieldRect.Contains(Event.current.mousePosition))
                {
                    var evt = Event.current;
                    switch (evt.type)
                    {
                        case EventType.DragUpdated:
                        case EventType.DragPerform:
                            // Validate dragged objects
                            var dragged = DragAndDrop.objectReferences;

                            bool valid = dragged.Length > 0 && dragged[0] is GameObject;
                            if (valid)
                                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                            else
                                DragAndDrop.visualMode = DragAndDropVisualMode.Rejected;

                            if (evt.type == EventType.DragPerform && valid)
                            {
                                DragAndDrop.AcceptDrag();
                                element.objectReferenceValue = dragged[0];
                                GUI.changed = true;
                            }

                            evt.Use();
                            break;
                    }
                }
            };
            _list.onChangedCallback = (ReorderableList l) =>
            {
                // This is called when the list is changed, e.g. items are added or removed.
                serializedObject.ApplyModifiedProperties();
            };
        }

        private void OnDisable()
        {
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
        }

        private void OnPlayModeStateChanged(PlayModeStateChange obj)
        {
            // without this block, the list is not updated when entering play mode, while the default Unity list is
            if (obj == PlayModeStateChange.EnteredPlayMode || obj == PlayModeStateChange.ExitingEditMode)
            {
                InitList();
                serializedObject.Update();
                Repaint();
            }
        }

        public override void OnInspectorGUI()
        {
            var serializedProperty = serializedObject.GetIterator();
            serializedProperty.NextVisible(true);

            while (serializedProperty.NextVisible(false))
            {
                // we render everything regularly, except the list itself
                if (serializedProperty.name != "list")
                {
                    EditorGUILayout.PropertyField(serializedProperty, true);
                }
                else
                {
                    _list?.DoLayoutList();
                }
            }

        }
    }
}
