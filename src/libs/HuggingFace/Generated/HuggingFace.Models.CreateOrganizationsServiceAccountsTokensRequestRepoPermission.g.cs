
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTokensRequestRepoPermission
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
    public static class CreateOrganizationsServiceAccountsTokensRequestRepoPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTokensRequestRepoPermission value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTokensRequestRepoPermission.RepoContentRead => "repo.content.read",
                CreateOrganizationsServiceAccountsTokensRequestRepoPermission.RepoWrite => "repo.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTokensRequestRepoPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => CreateOrganizationsServiceAccountsTokensRequestRepoPermission.RepoContentRead,
                "repo.write" => CreateOrganizationsServiceAccountsTokensRequestRepoPermission.RepoWrite,
                _ => null,
            };
        }
    }
}