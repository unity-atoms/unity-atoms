using System.Collections.Generic;
using UnityEditor;

namespace UnityAtoms
{
    /// <summary>
    /// Postprocessor that enables assigning icons to assets after importing them.
    /// You will need to add processor(s) or assigner(s) (to the CommonIconAssigmentProcessor)
    /// in order to acutally assign icons. Processors specifies an icon searh filter, its
    /// own settings path and assigners. Assigners specifies a function called SelectIcon
    /// that receives the asset and a list of icons (from assets filtered by the processors filter)
    /// and returns an icon for that asset if it should be applied.
    /// </summary>
    public partial class IconAssignmentPostprocessor : AssetPostprocessor
    {
        /// <summary>
        /// Add a processor to the postprocessor.
        /// </summary>
        /// <param name="processor">The processor to add.</param>
        public static void AddProcessor(IconAssignmentProcessor processor)
        {
            IconAssignmentProcessors.Add(processor);
        }

        /// <summary>
        /// Remove a processor to the postprocessor.
        /// </summary>
        /// <param name="processor">The processor to remove.</param>
        public static void RemoveProcessor(IconAssignmentProcessor processor)
        {
            IconAssignmentProcessors.Remove(processor);
        }

        /// <summary>
        /// Remove the common assignment postprocessor.
        /// </summary>
        /// <param name="processor">The processor to remove.</param>
        public static void RemoveCommonIconAssignmentProcessor()
        {
            var index = IconAssignmentProcessors.FindIndex((processor) => processor.GetType() == typeof(CommonIconAssignmentProcessor));
            if (index != -1)
            {
                IconAssignmentProcessors.RemoveAt(index);
            }
        }

        /// <summary>
        /// Add an assigner.
        /// </summary>
        /// <param name="iAssigner">The assigner to add.</param>
        public static void AddCommonAssigner(IIconAssigner iAssigner)
        {
            var commonProcessor = IconAssignmentProcessors[0];
            commonProcessor.AddAssigner(iAssigner);
        }

        /// <summary>
        /// Remove an assigner.
        /// </summary>
        /// <param name="iAssigner">The assigner to remove.</param>

        public static void RemoveCommonAssigner(IIconAssigner iAssigner)
        {
            var commonProcessor = IconAssignmentProcessors[0];
            commonProcessor.RemoveAssigner(iAssigner);
        }

        static List<IconAssignmentProcessor> IconAssignmentProcessors
        {
            get
            {
                if (_iconAssignmentProcessors == null)
                {
                    _iconAssignmentProcessors = new List<IconAssignmentProcessor>();
                }

                return _iconAssignmentProcessors;
            }
        }
        static List<IconAssignmentProcessor> _iconAssignmentProcessors;

        /* Create partial function to be able to apply configuration
         * (add / remove processor(s) and / or assigner(s)) before first time processing icons. */
        static partial void Configure();
        static bool hasAppliedConfiguration = false;

        static IconAssignmentPostprocessor()
        {
            if (IconAssignmentProcessors.Count == 0)
            {
                IconAssignmentProcessors.Add(new CommonIconAssignmentProcessor());
            }

            if (!hasAppliedConfiguration)
            {
                Configure();
                hasAppliedConfiguration = true;
            }

            foreach (var processor in IconAssignmentProcessors)
            {
                processor.ReloadIconsFromSettings();
            }
        }

        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
        {
            foreach (var processor in IconAssignmentProcessors)
            {
                processor.Process(importedAssets);
            }
        }
    }
}
