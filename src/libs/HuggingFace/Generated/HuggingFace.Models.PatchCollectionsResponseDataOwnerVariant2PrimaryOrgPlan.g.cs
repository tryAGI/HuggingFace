
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Academia => "academia",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Plus => "plus",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Plus,
                "team" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}