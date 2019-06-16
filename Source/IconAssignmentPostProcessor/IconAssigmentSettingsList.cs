using System;
using System.Collections.Generic;

namespace UnityAtoms
{
    [Serializable]
    public class IconAssigmentSettingsList
    {
        public IconAssigmentSettingsList()
        {
            List = new List<IconAssigmentSetting>();
        }

        public List<IconAssigmentSetting> List;
    }
}
