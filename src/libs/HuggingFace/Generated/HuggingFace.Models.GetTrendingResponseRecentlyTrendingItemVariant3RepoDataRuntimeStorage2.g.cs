
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2
    {
        /// <summary>
        /// 
        /// </summary>
        Large,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Small,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2 value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Large => "large",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Medium => "medium",
                GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Small => "small",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "large" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Large,
                "medium" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Medium,
                "small" => GetTrendingResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Small,
                _ => null,
            };
        }
    }
}