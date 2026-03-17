
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: publishedAt
    /// </summary>
    public enum Sort2
    {
        /// <summary>
        /// 
        /// </summary>
        PublishedAt,
        /// <summary>
        /// 
        /// </summary>
        Trending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Sort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sort2 value)
        {
            return value switch
            {
                Sort2.PublishedAt => "publishedAt",
                Sort2.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sort2? ToEnum(string value)
        {
            return value switch
            {
                "publishedAt" => Sort2.PublishedAt,
                "trending" => Sort2.Trending,
                _ => null,
            };
        }
    }
}