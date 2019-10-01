using System;
using UnityEngine;

namespace UnityAtoms
{
    [Serializable]
    public class IconData
    {
        public IconData(string name, string guid, string path, Texture2D asset)
        {
            Name = name;
            Guid = guid;
            Path = path;
            Asset = asset;
        }

        public string Name { get; set; }
        public string Guid { get; set; }
        public string Path { get; set; }
        public Texture2D Asset { get; set; }
    }
}
