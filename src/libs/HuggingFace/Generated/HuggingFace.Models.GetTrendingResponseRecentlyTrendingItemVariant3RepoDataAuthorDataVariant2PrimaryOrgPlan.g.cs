
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}