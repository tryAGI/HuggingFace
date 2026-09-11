
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: trending
    /// </summary>
    public enum GetBlogZhCommunitySort
    {
        /// <summary>
        ///
        /// </summary>
        Recent,
        /// <summary>
        ///
        /// </summary>
        Trending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetBlogZhCommunitySortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetBlogZhCommunitySort value)
        {
            return value switch
            {
                GetBlogZhCommunitySort.Recent => "recent",
                GetBlogZhCommunitySort.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetBlogZhCommunitySort? ToEnum(string value)
        {
            return value switch
            {
                "recent" => GetBlogZhCommunitySort.Recent,
                "trending" => GetBlogZhCommunitySort.Trending,
                _ => null,
            };
        }
    }
}