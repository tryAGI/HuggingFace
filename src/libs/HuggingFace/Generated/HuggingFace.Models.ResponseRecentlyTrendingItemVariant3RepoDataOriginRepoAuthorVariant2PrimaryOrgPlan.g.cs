
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}