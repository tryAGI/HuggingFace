
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutModelsSettingsRequestDiscussionsSorting
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
    public static class PutModelsSettingsRequestDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutModelsSettingsRequestDiscussionsSorting value)
        {
            return value switch
            {
                PutModelsSettingsRequestDiscussionsSorting.Reactions => "reactions",
                PutModelsSettingsRequestDiscussionsSorting.RecentlyCreated => "recently-created",
                PutModelsSettingsRequestDiscussionsSorting.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutModelsSettingsRequestDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => PutModelsSettingsRequestDiscussionsSorting.Reactions,
                "recently-created" => PutModelsSettingsRequestDiscussionsSorting.RecentlyCreated,
                "trending" => PutModelsSettingsRequestDiscussionsSorting.Trending,
                _ => null,
            };
        }
    }
}