using System;

namespace UnityAtoms
{
    /// <summary>
    /// Model for one icon assignment setting.
    /// </summary>
    [Serializable]
    public class IconAssigmentSetting
    {
        public IconAssigmentSetting(string assetPath, string iconPath)
        {
            AssetPath = assetPath;
            IconPath = iconPath;
        }

        public string AssetPath;
        public string IconPath;
    }
}
