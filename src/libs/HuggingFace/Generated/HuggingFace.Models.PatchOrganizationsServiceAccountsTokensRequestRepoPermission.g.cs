
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsServiceAccountsTokensRequestRepoPermission
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
    public static class PatchOrganizationsServiceAccountsTokensRequestRepoPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsServiceAccountsTokensRequestRepoPermission value)
        {
            return value switch
            {
                PatchOrganizationsServiceAccountsTokensRequestRepoPermission.RepoContentRead => "repo.content.read",
                PatchOrganizationsServiceAccountsTokensRequestRepoPermission.RepoWrite => "repo.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsServiceAccountsTokensRequestRepoPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => PatchOrganizationsServiceAccountsTokensRequestRepoPermission.RepoContentRead,
                "repo.write" => PatchOrganizationsServiceAccountsTokensRequestRepoPermission.RepoWrite,
                _ => null,
            };
        }
    }
}