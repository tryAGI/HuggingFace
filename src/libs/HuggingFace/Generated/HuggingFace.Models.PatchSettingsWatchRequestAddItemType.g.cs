
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchSettingsWatchRequestAddItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        Repo,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchSettingsWatchRequestAddItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchSettingsWatchRequestAddItemType value)
        {
            return value switch
            {
                PatchSettingsWatchRequestAddItemType.Org => "org",
                PatchSettingsWatchRequestAddItemType.Repo => "repo",
                PatchSettingsWatchRequestAddItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchSettingsWatchRequestAddItemType? ToEnum(string value)
        {
            return value switch
            {
                "org" => PatchSettingsWatchRequestAddItemType.Org,
                "repo" => PatchSettingsWatchRequestAddItemType.Repo,
                "user" => PatchSettingsWatchRequestAddItemType.User,
                _ => null,
            };
        }
    }
}