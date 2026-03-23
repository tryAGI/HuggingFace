
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2
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
    public static class PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Academia => "academia",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Plus => "plus",
                PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Plus,
                "team" => PatchCollectionsResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}