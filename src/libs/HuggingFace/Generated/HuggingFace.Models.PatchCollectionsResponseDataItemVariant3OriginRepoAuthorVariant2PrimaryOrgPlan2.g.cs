
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2
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
    public static class PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Plus,
                "team" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan2.Team,
                _ => null,
            };
        }
    }
}