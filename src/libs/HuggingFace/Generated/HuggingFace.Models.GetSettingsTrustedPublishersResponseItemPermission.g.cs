
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsTrustedPublishersResponseItemPermission
    {
        /// <summary>
        ///
        /// </summary>
        RepoContentRead,
        /// <summary>
        ///
        /// </summary>
        RepoContentWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetSettingsTrustedPublishersResponseItemPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsTrustedPublishersResponseItemPermission value)
        {
            return value switch
            {
                GetSettingsTrustedPublishersResponseItemPermission.RepoContentRead => "repo.content.read",
                GetSettingsTrustedPublishersResponseItemPermission.RepoContentWrite => "repo.content.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsTrustedPublishersResponseItemPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => GetSettingsTrustedPublishersResponseItemPermission.RepoContentRead,
                "repo.content.write" => GetSettingsTrustedPublishersResponseItemPermission.RepoContentWrite,
                _ => null,
            };
        }
    }
}