using UnityEditor;

namespace UnityAtoms
{
    public partial class IconAssignmentPostprocessor : AssetPostprocessor
    {
        static partial void Configure()
        {
            IconAssignmentPostprocessor.AddCommonAssigner(new AtomMonoScriptAssigner());
        }
    }
}
