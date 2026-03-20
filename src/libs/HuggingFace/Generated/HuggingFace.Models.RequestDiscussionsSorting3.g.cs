
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDiscussionsSorting3
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
    public static class RequestDiscussionsSorting3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDiscussionsSorting3 value)
        {
            return value switch
            {
                RequestDiscussionsSorting3.RecentlyCreated => "recently-created",
                RequestDiscussionsSorting3.Trending => "trending",
                RequestDiscussionsSorting3.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDiscussionsSorting3? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => RequestDiscussionsSorting3.RecentlyCreated,
                "trending" => RequestDiscussionsSorting3.Trending,
                "reactions" => RequestDiscussionsSorting3.Reactions,
                _ => null,
            };
        }
    }
}