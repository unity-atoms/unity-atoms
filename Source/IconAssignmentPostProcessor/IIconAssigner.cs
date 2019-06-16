using System.Collections.Generic;
using UnityEngine;

namespace UnityAtoms
{
    public interface IIconAssigner
    {
        void Assign(string assetPath, List<IconData> icons, IconAssigmentSettings settings);
    }
}
