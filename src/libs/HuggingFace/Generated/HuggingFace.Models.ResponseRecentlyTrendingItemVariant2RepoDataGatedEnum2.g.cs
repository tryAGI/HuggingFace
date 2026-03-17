
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2
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
    public static class ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2 value)
        {
            return value switch
            {
                ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2.Auto => "auto",
                ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2.Auto,
                "manual" => ResponseRecentlyTrendingItemVariant2RepoDataGatedEnum2.Manual,
                _ => null,
            };
        }
    }
}