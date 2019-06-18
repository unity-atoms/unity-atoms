using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityAtoms
{
    public abstract class IconAssignmentProcessor
    {
        protected abstract string IconSearchFilter { get; }
        protected virtual string SettingsPath { get => $"{Application.dataPath}{Path.DirectorySeparatorChar}IconAssignmentSettings.json"; }
        protected abstract List<IIconAssigner> IconAssigners { get; }

        private List<IconData> _icons = new List<IconData>();
        private IconAssigmentSettings _settings;
        private bool _haveReloadIconsFromSettings = false;

        public IconAssignmentProcessor()
        {
            _settings = new IconAssigmentSettings(SettingsPath);
        }

        public void Process(string[] importedAssets)
        {
            GenerateIconsList();

            foreach (string assetPath in importedAssets)
            {
                foreach (var iconAssigner in IconAssigners)
                {
                    iconAssigner.Assign(assetPath, _icons, _settings);
                }
            }

            _settings.SaveToFile();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        public void ReloadIconsFromSettings()
        {
            if (_haveReloadIconsFromSettings) { return; }
            _haveReloadIconsFromSettings = true;

            GenerateIconsList();
            _settings.LoadFromFile();

            var listOfSettings = _settings.GetListOfSettings();
            for (var i = listOfSettings != null ? listOfSettings.Count - 1 : -1; listOfSettings != null && i >= 0; --i)
            {
                if (!File.Exists(listOfSettings[i].AssetPath))
                {
                    _settings.RemoveAt(i);
                    continue;
                }

                foreach (var iconAssigner in IconAssigners)
                {
                    iconAssigner.Assign(listOfSettings[i].AssetPath, _icons, _settings);
                }
            }

            _settings.SaveToFile();
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        private void GenerateIconsList()
        {
            var iconGuids = AssetDatabase.FindAssets(!string.IsNullOrEmpty(IconSearchFilter) ? $"{IconSearchFilter} t:texture2D" : "t:texture2D");
            var iconGuidsList = iconGuids.ToList();

            // Add icons to our internal list
            foreach (var iconGuid in iconGuidsList)
            {
                var path = AssetDatabase.GUIDToAssetPath(iconGuid);
                var iconAsset = AssetDatabase.LoadAssetAtPath<Texture2D>(path);
                var icon = _icons.Find((i) => i.Guid == iconGuid);
                if (icon != null)
                {
                    icon.Name = iconAsset.name;
                    icon.Asset = iconAsset;
                }
                else
                {
                    _icons.Add(new IconData(iconAsset.name, iconGuid, path, iconAsset));
                }
            }

            // Remove icons from list if they do not exist anymore
            for (var i = _icons != null ? _icons.Count - 1 : -1; _icons != null && i >= 0; --i)
            {
                var icon = _icons[i];
                if (!iconGuidsList.Exists((guid) => guid == icon.Guid))
                {
                    _icons.Remove(icon);
                }
            }
        }
    }
}
