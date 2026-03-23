
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutModelsSettingsResponseDiscussionsSorting
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
    public static class PutModelsSettingsResponseDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsResponseDiscussionsSorting value)
        {
            return value switch
            {
                PutModelsSettingsResponseDiscussionsSorting.Reactions => "reactions",
                PutModelsSettingsResponseDiscussionsSorting.RecentlyCreated => "recently-created",
                PutModelsSettingsResponseDiscussionsSorting.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsResponseDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => PutModelsSettingsResponseDiscussionsSorting.Reactions,
                "recently-created" => PutModelsSettingsResponseDiscussionsSorting.RecentlyCreated,
                "trending" => PutModelsSettingsResponseDiscussionsSorting.Trending,
                _ => null,
            };
        }
    }
}