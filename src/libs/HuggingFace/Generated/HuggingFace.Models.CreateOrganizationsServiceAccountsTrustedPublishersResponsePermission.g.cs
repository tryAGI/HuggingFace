
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission
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
    public static class CreateOrganizationsServiceAccountsTrustedPublishersResponsePermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission.RepoContentRead => "repo.content.read",
                CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission.RepoContentWrite => "repo.content.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission.RepoContentRead,
                "repo.content.write" => CreateOrganizationsServiceAccountsTrustedPublishersResponsePermission.RepoContentWrite,
                _ => null,
            };
        }
    }
}