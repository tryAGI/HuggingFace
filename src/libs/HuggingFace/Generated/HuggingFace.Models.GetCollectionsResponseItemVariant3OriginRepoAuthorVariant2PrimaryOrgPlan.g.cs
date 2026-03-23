
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan
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
    public static class GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}