using System.IO;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace UnityAtoms
{
    /// <summary>
    /// An IconAssignmentProcessor is used by IconAssignmentPostprocessor. It specifies
    /// an icon search filter (icons to use by calling AssetDatabase.FindAssets), if you
    /// don't specify a filter all asset images can be later be selected by one of the assigners.
    /// A processor also contains a list assigners that are called on each asset import. See
    /// the IconAssigner class for more info about it.
    /// </summary>
    public abstract class IconAssignmentProcessor
    {
        // Override in order to specifiy your own icon search filter.
        protected virtual string IconSearchFilter { get => null; }
        // Override in order to specifiy your own path where the icon settings are stored.
        protected virtual string SettingsPath { get => $"{Application.dataPath}{Path.DirectorySeparatorChar}IconAssignmentSettings.json"; }
        protected List<IIconAssigner> IconAssigners
        {
            get
            {
                if (_iconAssigners == null)
                {
                    _iconAssigners = new List<IIconAssigner>();
                }
                return _iconAssigners;
            }
        }

        private List<IIconAssigner> _iconAssigners;
        private List<IconData> _icons = new List<IconData>();
        private IconAssigmentSettings _settings;
        private bool _haveReloadedIconsFromSettings = false;

        public void AddAssigner(IIconAssigner iAssigner)
        {
            IconAssigners.Add(iAssigner);
        }

        public void RemoveAssigner(IIconAssigner iAssigner)
        {
            IconAssigners.Remove(iAssigner);
        }

        public IconAssignmentProcessor()
        {
            _settings = new IconAssigmentSettings(SettingsPath);
        }

        /// <summary>
        /// Handles icon settings and call all icon assigners for each imported asset.
        /// </summary>
        /// <param name="importedAssets">List of imported assets.</param>
        public void Process(string[] importedAssets)
        {
            UpdateIconsList();

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

        /// <summary>
        /// Called on startup in order reload all icons from stored settings.
        /// </summary>
        public void ReloadIconsFromSettings()
        {
            if (_haveReloadedIconsFromSettings) { return; }
            _haveReloadedIconsFromSettings = true;

            UpdateIconsList();
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

        private void UpdateIconsList()
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
