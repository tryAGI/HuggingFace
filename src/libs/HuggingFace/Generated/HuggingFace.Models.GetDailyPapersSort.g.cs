
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: publishedAt
    /// </summary>
    public enum GetDailyPapersSort
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
    public static class GetDailyPapersSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDailyPapersSort value)
        {
            return value switch
            {
                GetDailyPapersSort.PublishedAt => "publishedAt",
                GetDailyPapersSort.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDailyPapersSort? ToEnum(string value)
        {
            return value switch
            {
                "publishedAt" => GetDailyPapersSort.PublishedAt,
                "trending" => GetDailyPapersSort.Trending,
                _ => null,
            };
        }
    }
}