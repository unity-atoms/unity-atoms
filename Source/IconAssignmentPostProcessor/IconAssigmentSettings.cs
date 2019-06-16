using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class IconAssigmentSettings
    {
        public string SettingsPath { get; set; }
        private IconAssigmentSettingsList _listOfSettings;

        public IconAssigmentSettings(string settingsPath)
        {
            SettingsPath = settingsPath;
            _listOfSettings = new IconAssigmentSettingsList();
        }

        public void Add(IconAssigmentSetting setting)
        {
            var currentSetting = _listOfSettings.List.Find((s) => s.AssetPath == setting.AssetPath);
            if (currentSetting != null)
            {
                currentSetting.IconPath = setting.IconPath;
            }
            else
            {
                _listOfSettings.List.Add(setting);
            }
        }

        public void RemoveAt(int index)
        {
            if (index > -1 && index < _listOfSettings.List.Count)
            {
                _listOfSettings.List.RemoveAt(index);
            }
        }

        public List<IconAssigmentSetting> GetListOfSettings()
        {
            return _listOfSettings.List;
        }

        public void SaveToFile()
        {
            CreateSettingsIfNotExists();
            try
            {
                string json = JsonUtility.ToJson(_listOfSettings, true);
                File.WriteAllBytes(SettingsPath, Encoding.ASCII.GetBytes(json));
            }
            catch (Exception)
            {
                Debug.LogError("Not able to save settings to file.");
            }
        }

        public void LoadFromFile()
        {
            CreateSettingsIfNotExists();
            try
            {
                byte[] data = File.ReadAllBytes(SettingsPath);
                string json = Encoding.ASCII.GetString(data);
                _listOfSettings = JsonUtility.FromJson<IconAssigmentSettingsList>(json);
            }
            catch (Exception e)
            {
                Debug.LogError("No Settings Loaded: " + e.Message);
            }
        }

        private void CreateSettingsIfNotExists()
        {
            if (!File.Exists(SettingsPath))
            {
                using (StreamWriter sw = File.CreateText(SettingsPath))
                {
                    sw.WriteLine("{}");
                }
            }
        }
    }
}
