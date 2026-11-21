
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission
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
    public static class CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoContentRead => "repo.content.read",
                CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoWrite => "repo.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoContentRead,
                "repo.write" => CreateOrganizationsServiceAccountsTokensRequestResourceGroupPermission.RepoWrite,
                _ => null,
            };
        }
    }
}