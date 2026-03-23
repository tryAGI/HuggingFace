
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchSettingsWatchRequestDeleteItemType
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
    public static class PatchSettingsWatchRequestDeleteItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchSettingsWatchRequestDeleteItemType value)
        {
            return value switch
            {
                PatchSettingsWatchRequestDeleteItemType.Org => "org",
                PatchSettingsWatchRequestDeleteItemType.Repo => "repo",
                PatchSettingsWatchRequestDeleteItemType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchSettingsWatchRequestDeleteItemType? ToEnum(string value)
        {
            return value switch
            {
                "org" => PatchSettingsWatchRequestDeleteItemType.Org,
                "repo" => PatchSettingsWatchRequestDeleteItemType.Repo,
                "user" => PatchSettingsWatchRequestDeleteItemType.User,
                _ => null,
            };
        }
    }
}