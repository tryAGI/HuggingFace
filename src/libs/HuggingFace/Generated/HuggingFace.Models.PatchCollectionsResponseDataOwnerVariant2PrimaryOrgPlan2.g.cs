
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2
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
    public static class PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Academia => "academia",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Plus => "plus",
                PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Plus,
                "team" => PatchCollectionsResponseDataOwnerVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}