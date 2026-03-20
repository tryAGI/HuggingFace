
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDiscussionsSorting2
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
    public static class RequestDiscussionsSorting2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDiscussionsSorting2 value)
        {
            return value switch
            {
                RequestDiscussionsSorting2.RecentlyCreated => "recently-created",
                RequestDiscussionsSorting2.Trending => "trending",
                RequestDiscussionsSorting2.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDiscussionsSorting2? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => RequestDiscussionsSorting2.RecentlyCreated,
                "trending" => RequestDiscussionsSorting2.Trending,
                "reactions" => RequestDiscussionsSorting2.Reactions,
                _ => null,
            };
        }
    }
}