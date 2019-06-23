using System;
using System.Reflection;
using System.Collections.Generic;
using UnityEditor;

namespace UnityAtoms
{
    public abstract class IconAssigner<T> : IIconAssigner
        where T : UnityEngine.Object
    {
        public void Assign(string assetPath, List<IconData> icons, IconAssigmentSettings settings)
        {
            DoAssign(assetPath, icons, settings);
        }

        protected abstract Func<T, List<IconData>, IconData> SelectIcon { get; }

        private void DoAssign(string assetPath, List<IconData> icons, IconAssigmentSettings settings)
        {
            var asset = AssetDatabase.LoadAssetAtPath<T>(assetPath);
            if (asset != null)
            {
                var icon = SelectIcon(asset, icons);
                if (icon != null)
                {
                    PropertyInfo inspectorModeInfo = typeof(SerializedObject).GetProperty("inspectorMode", BindingFlags.NonPublic | BindingFlags.Instance);
                    SerializedObject serializedObject = new SerializedObject(asset);
                    inspectorModeInfo.SetValue(serializedObject, InspectorMode.Debug, null);
                    SerializedProperty iconProperty = serializedObject.FindProperty("m_Icon");
                    iconProperty.objectReferenceValue = icon.Asset;
                    serializedObject.ApplyModifiedProperties();
                    serializedObject.Update();
                    EditorUtility.SetDirty(asset);
                    settings.Add(new IconAssigmentSetting(assetPath, icon.Path));
                }
            }
        }
    }
}
