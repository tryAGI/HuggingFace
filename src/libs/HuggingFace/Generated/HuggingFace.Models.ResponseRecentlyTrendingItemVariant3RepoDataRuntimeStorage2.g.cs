
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2
    {
        /// <summary>
        /// 
        /// </summary>
        Small,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Large,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2 value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Small => "small",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Medium => "medium",
                ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Large => "large",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2? ToEnum(string value)
        {
            return value switch
            {
                "small" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Small,
                "medium" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Medium,
                "large" => ResponseRecentlyTrendingItemVariant3RepoDataRuntimeStorage2.Large,
                _ => null,
            };
        }
    }
}