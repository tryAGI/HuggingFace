
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutDatasetsSettingsRequestDiscussionsSorting
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
    public static class PutDatasetsSettingsRequestDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsRequestDiscussionsSorting value)
        {
            return value switch
            {
                PutDatasetsSettingsRequestDiscussionsSorting.Reactions => "reactions",
                PutDatasetsSettingsRequestDiscussionsSorting.RecentlyCreated => "recently-created",
                PutDatasetsSettingsRequestDiscussionsSorting.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsRequestDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => PutDatasetsSettingsRequestDiscussionsSorting.Reactions,
                "recently-created" => PutDatasetsSettingsRequestDiscussionsSorting.RecentlyCreated,
                "trending" => PutDatasetsSettingsRequestDiscussionsSorting.Trending,
                _ => null,
            };
        }
    }
}