
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission
    {
        /// <summary>
        ///
        /// </summary>
        RepoContentRead,
        /// <summary>
        ///
        /// </summary>
        RepoWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission.RepoContentRead => "repo.content.read",
                GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission.RepoWrite => "repo.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission.RepoContentRead,
                "repo.write" => GetOrganizationsServiceAccountsResponseAccessTokenResourceGroupPermission.RepoWrite,
                _ => null,
            };
        }
    }
}