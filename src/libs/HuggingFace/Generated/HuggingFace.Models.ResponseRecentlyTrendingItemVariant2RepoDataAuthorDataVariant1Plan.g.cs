
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan
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
    public static class ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Team => "team",
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Enterprise => "enterprise",
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Plus => "plus",
                ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Team,
                "enterprise" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Enterprise,
                "plus" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Plus,
                "academia" => ResponseRecentlyTrendingItemVariant2RepoDataAuthorDataVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}