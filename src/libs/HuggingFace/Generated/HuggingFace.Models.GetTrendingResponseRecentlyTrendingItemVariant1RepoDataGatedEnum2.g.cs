
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2
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
    public static class GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2 value)
        {
            return value switch
            {
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Auto => "auto",
                GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Auto,
                "manual" => GetTrendingResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}