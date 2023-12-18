using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// A custom property drawer for References (Events and regular). Makes it possible to reference a resources (Variable or Event) through multiple options.
    /// </summary>
    public abstract class AtomBaseReferenceDrawer : PropertyDrawer
    {
        protected abstract class UsageData
        {
            public abstract int Value { get; }
            public abstract string PropertyName { get; }
            public abstract string DisplayName { get; }
        }
        private const string USAGE_PROPERTY_NAME = "_usage";

        protected abstract UsageData[] GetUsages(SerializedProperty prop = null);

        private string[] GetPopupOptions(SerializedProperty prop = null) => GetUsages(prop).Select(u => u.DisplayName).ToArray();
        private static GUIStyle _popupStyle;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            GuiData guiData = new GuiData()
            {
                Position = position,
                Property = property,
                Label = label
            };

            if (_popupStyle == null)
            {
                _popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"))
                {
                    imagePosition = ImagePosition.ImageOnly
                };
            }

            using (var scope = new EditorGUI.PropertyScope(position, label, property))
            {
                guiData.Label = scope.content;
                guiData.Position = EditorGUI.PrefixLabel(position, label);
                // Store old indent level and set it to 0, the PrefixLabel takes care of it
                int indent = EditorGUI.indentLevel;
                EditorGUI.indentLevel = 0;
                {
                    EditorGUI.BeginChangeCheck();
                    {
                        DetermineDragAndDropFieldReferenceType(guiData);
                        DrawConfigurationButton(ref guiData);
                        string currentUsageTypePropertyName = GetUsages(property)[GetUsageIndex(property)].PropertyName;
                        DrawField(currentUsageTypePropertyName, guiData, position);
                    }
                    if (EditorGUI.EndChangeCheck())
                    {
                        property.serializedObject.ApplyModifiedProperties();
                    }
                }
                EditorGUI.indentLevel = indent;
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var usageIntVal = GetUsageIndex(property);
            var usageData = GetUsages(property)[0];

            for (int i = 0; i < GetUsages(property).Length; ++i)
            {
                if (GetUsages(property)[i].Value == usageIntVal)
                {
                    usageData = GetUsages(property)[i];
                    break;
                }
            }

            var innerProperty = property.FindPropertyRelative(usageData.PropertyName);

            bool forceSingleLine = false;
#if UNITY_2021_2_OR_NEWER
            // This is needed for similar reasons as described in the comment in the DrawField method below.
            // This is basically a hack to fix a bug on Unity's side, which we need to revert when / if Unity fix it on their side.
            forceSingleLine = innerProperty != null && innerProperty.propertyType == SerializedPropertyType.Quaternion;
#endif

            return innerProperty == null || forceSingleLine ?
                EditorGUIUtility.singleLineHeight :
                EditorGUI.GetPropertyHeight(innerProperty, label);
        }

        private void DrawConfigurationButton(ref GuiData guiData)
        {
            Rect button = new Rect(guiData.Position);
            button.yMin += _popupStyle.margin.top;
            button.yMax = button.yMin + EditorGUIUtility.singleLineHeight;
            button.width = _popupStyle.fixedWidth + _popupStyle.margin.right;
            guiData.Position.xMin = button.xMax;

            var currentUsageIndex = GetUsageIndex(guiData.Property);
            var newUsageValue = EditorGUI.Popup(button, currentUsageIndex, GetPopupOptions(guiData.Property), _popupStyle);
            SetUsageIndex(guiData.Property, newUsageValue);
        }

        private static void DrawField(string usageTypePropertyName, in GuiData guiData, in Rect originalPosition)
        {
            var usageTypeProperty = guiData.Property.FindPropertyRelative(usageTypePropertyName);

            if (usageTypeProperty == null)
            {
                EditorGUI.LabelField(guiData.Position, "[Non serialized value]");
            }
            else
            {
                var expanded = usageTypeProperty.isExpanded;
                usageTypeProperty.isExpanded = true;
#if UNITY_2021_2_OR_NEWER
                var valueFieldHeight = usageTypeProperty.propertyType == SerializedPropertyType.Quaternion ?
                    // In versions prior to 2022.3 GetPropertyHeight returns the wrong value for "SerializedPropertyType.Quaternion"
                    // In later versions, the fix is introduced _but only_ when using the SerializedPropertyType parameter, not when using the SerializedProperty parameter version.
                    // ALSO the SerializedPropertyType parameter version does not work with the isExpanded flag which we set to true exactly for this reason a (few) lines above.
                    EditorGUI.GetPropertyHeight(SerializedPropertyType.Vector3, guiData.Label) :
                    EditorGUI.GetPropertyHeight(usageTypeProperty, guiData.Label);
#else
                var valueFieldHeight = EditorGUI.GetPropertyHeight(usageTypeProperty, guiData.Label);
#endif

                usageTypeProperty.isExpanded = expanded;

                if (usageTypePropertyName == "_value" && (valueFieldHeight > EditorGUIUtility.singleLineHeight + 2))
                {
                    EditorGUI.PropertyField(originalPosition, usageTypeProperty, GUIContent.none, true);
                }
                else
                {
                    EditorGUI.PropertyField(guiData.Position, usageTypeProperty, GUIContent.none);
                }
            }
        }

        private static void SetUsageIndex(SerializedProperty property, int index)
        {
            property.FindPropertyRelative(USAGE_PROPERTY_NAME).intValue = index;
        }

        private static int GetUsageIndex(SerializedProperty property)
        {
            return property.FindPropertyRelative(USAGE_PROPERTY_NAME).intValue;
        }


        #region Auto Drag And Drop Usage Type Detection
        private void DetermineDragAndDropFieldReferenceType(in GuiData guiData)
        {
            EventType mouseEventType = Event.current.type;

            if (mouseEventType != EventType.DragUpdated && mouseEventType != EventType.DragPerform)
            {
                return;
            }

            if (!IsMouseHoveringOverProperty(guiData.Position))
            {
                return;
            }

            var draggedObjects = DragAndDrop.objectReferences;
            if (draggedObjects.Length < 1)
            {
                return;
            }

            Object draggedObject = draggedObjects[0];

            if (draggedObject is GameObject gameObject)
            {
                object[] instancers = gameObject.GetComponents<IAtomInstancer>();
                UpdateUsageConfigurationOption(guiData.Property, instancers);
            }
            else
            {
                UpdateUsageConfigurationOption(guiData.Property, draggedObject);
            }
        }

        private void UpdateUsageConfigurationOption(SerializedProperty property, params object[] draggedObjects)
        {
            if (draggedObjects == null || draggedObjects.Length < 1)
            {
                return;
            }

            var usages = GetUsages(property);
            int currentUsageIndex = GetUsageIndex(property);
            int newUsageIndex = -1;

            foreach (object draggedObject in draggedObjects)
            {
                for (int index = 0; index < usages.Length; index++)
                {
                    var usage = usages[index];
                    var usageProperty = property.FindPropertyRelative(usage.PropertyName);
                    bool isDraggedTypeSameAsUsageType = AreTypesEqual(usageProperty, draggedObject);

                    if (isDraggedTypeSameAsUsageType)
                    {
                        bool isUsageSetByUser = currentUsageIndex == index;

                        if (isUsageSetByUser)
                        {
                            return;
                        }

                        bool isNewUsageIndexSet = newUsageIndex > -1;
                        if (!isNewUsageIndexSet)
                        {
                            newUsageIndex = index;
                        }

                        break;
                    }
                }
            }

            if (newUsageIndex > -1)
            {
                SetUsageIndex(property, newUsageIndex);
            }
        }

        private static bool AreTypesEqual(SerializedProperty property, object otherObject)
        {
            string otherObjectTypeName = otherObject.GetType().Name;
            string propertyObjectTypeName = GetPropertyTypeName(property);
            return otherObjectTypeName == propertyObjectTypeName;
        }

        private static readonly string PPTR_GENERIC_PREFIX = "PPtr<$";
        private static string GetPropertyTypeName(SerializedProperty property)
        {
            if (!property.type.StartsWith(PPTR_GENERIC_PREFIX))
            {
                return property.type;
            }
            string fieldPropertyType = property.type.Replace(PPTR_GENERIC_PREFIX, "");
            return fieldPropertyType.Remove(fieldPropertyType.Length - 1);
        }

        private static bool IsMouseHoveringOverProperty(in Rect rectPosition)
        {
            const int HEIGHT_OFFSET_TO_AVOID_OVERLAP = 1;
            Rect controlRect = rectPosition;
            controlRect.height -= HEIGHT_OFFSET_TO_AVOID_OVERLAP;

            return controlRect.Contains(Event.current.mousePosition);
        }
        #endregion
    }
}
