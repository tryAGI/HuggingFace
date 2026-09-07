
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated.Auto => "auto",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated.Auto,
                "manual" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGated.Manual,
                _ => null,
            };
        }
    }
}