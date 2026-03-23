
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesSettingsResponseDiscussionsSorting
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
    public static class PutSpacesSettingsResponseDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsResponseDiscussionsSorting value)
        {
            return value switch
            {
                PutSpacesSettingsResponseDiscussionsSorting.Reactions => "reactions",
                PutSpacesSettingsResponseDiscussionsSorting.RecentlyCreated => "recently-created",
                PutSpacesSettingsResponseDiscussionsSorting.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsResponseDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => PutSpacesSettingsResponseDiscussionsSorting.Reactions,
                "recently-created" => PutSpacesSettingsResponseDiscussionsSorting.RecentlyCreated,
                "trending" => PutSpacesSettingsResponseDiscussionsSorting.Trending,
                _ => null,
            };
        }
    }
}