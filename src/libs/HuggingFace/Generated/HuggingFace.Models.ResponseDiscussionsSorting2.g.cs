
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionsSorting2
    {
        /// <summary>
        /// 
        /// </summary>
        RecentlyCreated,
        /// <summary>
        /// 
        /// </summary>
        Trending,
        /// <summary>
        /// 
        /// </summary>
        Reactions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDiscussionsSorting2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionsSorting2 value)
        {
            return value switch
            {
                ResponseDiscussionsSorting2.RecentlyCreated => "recently-created",
                ResponseDiscussionsSorting2.Trending => "trending",
                ResponseDiscussionsSorting2.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionsSorting2? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => ResponseDiscussionsSorting2.RecentlyCreated,
                "trending" => ResponseDiscussionsSorting2.Trending,
                "reactions" => ResponseDiscussionsSorting2.Reactions,
                _ => null,
            };
        }
    }
}