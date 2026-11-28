
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission
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
    public static class PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission value)
        {
            return value switch
            {
                PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoContentRead => "repo.content.read",
                PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoWrite => "repo.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoContentRead,
                "repo.write" => PatchOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoWrite,
                _ => null,
            };
        }
    }
}