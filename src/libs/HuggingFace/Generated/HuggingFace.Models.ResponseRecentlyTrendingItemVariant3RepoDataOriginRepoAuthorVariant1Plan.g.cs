
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan
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
    public static class ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Team => "team",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Enterprise => "enterprise",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Plus => "plus",
                ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Team,
                "enterprise" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Enterprise,
                "plus" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Plus,
                "academia" => ResponseRecentlyTrendingItemVariant3RepoDataOriginRepoAuthorVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}