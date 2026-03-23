
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan
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
    public static class PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Academia => "academia",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Plus => "plus",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Plus,
                "team" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}