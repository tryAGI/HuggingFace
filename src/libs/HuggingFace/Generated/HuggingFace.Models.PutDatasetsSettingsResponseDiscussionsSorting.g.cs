
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutDatasetsSettingsResponseDiscussionsSorting
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
    public static class PutDatasetsSettingsResponseDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutDatasetsSettingsResponseDiscussionsSorting value)
        {
            return value switch
            {
                PutDatasetsSettingsResponseDiscussionsSorting.Reactions => "reactions",
                PutDatasetsSettingsResponseDiscussionsSorting.RecentlyCreated => "recently-created",
                PutDatasetsSettingsResponseDiscussionsSorting.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutDatasetsSettingsResponseDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => PutDatasetsSettingsResponseDiscussionsSorting.Reactions,
                "recently-created" => PutDatasetsSettingsResponseDiscussionsSorting.RecentlyCreated,
                "trending" => PutDatasetsSettingsResponseDiscussionsSorting.Trending,
                _ => null,
            };
        }
    }
}