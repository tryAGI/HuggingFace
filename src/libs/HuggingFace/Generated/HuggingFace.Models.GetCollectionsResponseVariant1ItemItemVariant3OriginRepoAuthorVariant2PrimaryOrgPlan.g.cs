
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan
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
    public static class GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetCollectionsResponseVariant1ItemItemVariant3OriginRepoAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}