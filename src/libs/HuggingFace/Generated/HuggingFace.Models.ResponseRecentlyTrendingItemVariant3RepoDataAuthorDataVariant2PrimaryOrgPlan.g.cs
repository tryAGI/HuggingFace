
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan
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
    public static class ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Team => "team",
                ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseRecentlyTrendingItemVariant3RepoDataAuthorDataVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}