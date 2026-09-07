
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated
    {
        /// <summary>
        ///
        /// </summary>
        Auto,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated.Auto => "auto",
                GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated.Auto,
                "manual" => GetTrendingResponseRecentlyTrendingItemVariant2RepoDataGated.Manual,
                _ => null,
            };
        }
    }
}