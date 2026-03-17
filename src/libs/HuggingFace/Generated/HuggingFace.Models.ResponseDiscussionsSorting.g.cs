
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionsSorting
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
    public static class ResponseDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionsSorting value)
        {
            return value switch
            {
                ResponseDiscussionsSorting.RecentlyCreated => "recently-created",
                ResponseDiscussionsSorting.Trending => "trending",
                ResponseDiscussionsSorting.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => ResponseDiscussionsSorting.RecentlyCreated,
                "trending" => ResponseDiscussionsSorting.Trending,
                "reactions" => ResponseDiscussionsSorting.Reactions,
                _ => null,
            };
        }
    }
}