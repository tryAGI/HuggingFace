
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission
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
    public static class GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission.RepoContentRead => "repo.content.read",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission.RepoContentWrite => "repo.content.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission.RepoContentRead,
                "repo.content.write" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemPermission.RepoContentWrite,
                _ => null,
            };
        }
    }
}