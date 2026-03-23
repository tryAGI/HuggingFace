
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: recently-created
    /// </summary>
    public enum GetDiscussionsSort
    {
        /// <summary>
        /// 
        /// </summary>
        Reactions,
        /// <summary>
        /// 
        /// </summary>
        RecentlyCreated,
        /// <summary>
        /// 
        /// </summary>
        Trending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsSort value)
        {
            return value switch
            {
                GetDiscussionsSort.Reactions => "reactions",
                GetDiscussionsSort.RecentlyCreated => "recently-created",
                GetDiscussionsSort.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsSort? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => GetDiscussionsSort.Reactions,
                "recently-created" => GetDiscussionsSort.RecentlyCreated,
                "trending" => GetDiscussionsSort.Trending,
                _ => null,
            };
        }
    }
}