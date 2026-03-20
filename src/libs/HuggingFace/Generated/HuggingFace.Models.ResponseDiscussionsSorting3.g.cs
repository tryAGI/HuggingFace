
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionsSorting3
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
    public static class ResponseDiscussionsSorting3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionsSorting3 value)
        {
            return value switch
            {
                ResponseDiscussionsSorting3.RecentlyCreated => "recently-created",
                ResponseDiscussionsSorting3.Trending => "trending",
                ResponseDiscussionsSorting3.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionsSorting3? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => ResponseDiscussionsSorting3.RecentlyCreated,
                "trending" => ResponseDiscussionsSorting3.Trending,
                "reactions" => ResponseDiscussionsSorting3.Reactions,
                _ => null,
            };
        }
    }
}