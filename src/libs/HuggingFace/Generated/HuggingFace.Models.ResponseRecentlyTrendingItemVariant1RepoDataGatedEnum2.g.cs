
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2
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
    public static class ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2 value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Auto => "auto",
                ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Auto,
                "manual" => ResponseRecentlyTrendingItemVariant1RepoDataGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}