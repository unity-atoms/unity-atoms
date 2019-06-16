using System;
using UnityEngine;

namespace UnityAtoms
{
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
