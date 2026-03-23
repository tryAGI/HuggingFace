
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutSpacesSettingsRequestDiscussionsSorting
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
    public static class PutSpacesSettingsRequestDiscussionsSortingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutSpacesSettingsRequestDiscussionsSorting value)
        {
            return value switch
            {
                PutSpacesSettingsRequestDiscussionsSorting.Reactions => "reactions",
                PutSpacesSettingsRequestDiscussionsSorting.RecentlyCreated => "recently-created",
                PutSpacesSettingsRequestDiscussionsSorting.Trending => "trending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutSpacesSettingsRequestDiscussionsSorting? ToEnum(string value)
        {
            return value switch
            {
                "reactions" => PutSpacesSettingsRequestDiscussionsSorting.Reactions,
                "recently-created" => PutSpacesSettingsRequestDiscussionsSorting.RecentlyCreated,
                "trending" => PutSpacesSettingsRequestDiscussionsSorting.Trending,
                _ => null,
            };
        }
    }
}