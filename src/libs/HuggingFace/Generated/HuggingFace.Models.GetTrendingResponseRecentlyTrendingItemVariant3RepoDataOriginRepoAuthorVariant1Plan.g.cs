
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Academia => "academia",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Enterprise => "enterprise",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Plus => "plus",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Academia,
                "enterprise" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Enterprise,
                "plus" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Plus,
                "team" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Team,
                _ => null,
            };
        }
    }
}