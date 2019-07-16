namespace UnityAtoms
{
    /// <summary>
    /// Common icon assignment processor that adds the attribute assigner, which
    /// makes the attribute AssignIcon work.
    /// </summary>
    internal class CommonIconAssignmentProcessor : IconAssignmentProcessor
    {
        public CommonIconAssignmentProcessor()
        {
            IconAssigners.Add(new AttributeMonoScriptAssigner());
        }
    }
}
