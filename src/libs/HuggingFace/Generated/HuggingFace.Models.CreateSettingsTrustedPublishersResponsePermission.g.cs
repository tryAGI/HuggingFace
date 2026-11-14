
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateSettingsTrustedPublishersResponsePermission
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
    public static class CreateSettingsTrustedPublishersResponsePermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSettingsTrustedPublishersResponsePermission value)
        {
            return value switch
            {
                CreateSettingsTrustedPublishersResponsePermission.RepoContentRead => "repo.content.read",
                CreateSettingsTrustedPublishersResponsePermission.RepoContentWrite => "repo.content.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSettingsTrustedPublishersResponsePermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => CreateSettingsTrustedPublishersResponsePermission.RepoContentRead,
                "repo.content.write" => CreateSettingsTrustedPublishersResponsePermission.RepoContentWrite,
                _ => null,
            };
        }
    }
}