
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestDiscussionsSorting
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
    public static class RequestDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestDiscussionsSorting value)
        {
            return value switch
            {
                RequestDiscussionsSorting.RecentlyCreated => "recently-created",
                RequestDiscussionsSorting.Trending => "trending",
                RequestDiscussionsSorting.Reactions => "reactions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "recently-created" => RequestDiscussionsSorting.RecentlyCreated,
                "trending" => RequestDiscussionsSorting.Trending,
                "reactions" => RequestDiscussionsSorting.Reactions,
                _ => null,
            };
        }
    }
}