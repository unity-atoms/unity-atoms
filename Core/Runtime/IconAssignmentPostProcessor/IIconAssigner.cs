using System.Collections.Generic;

namespace UnityAtoms
{
    public interface IIconAssigner
    {
        void Assign(string assetPath, List<IconData> icons, IconAssigmentSettings settings);
    }
}
