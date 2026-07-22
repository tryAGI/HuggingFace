
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission
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
    public static class GetOrganizationsServiceAccountsResponseAccessTokenRepoPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission.RepoContentRead => "repo.content.read",
                GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission.RepoWrite => "repo.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission? ToEnum(string value)
        {
            return value switch
            {
                "repo.content.read" => GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission.RepoContentRead,
                "repo.write" => GetOrganizationsServiceAccountsResponseAccessTokenRepoPermission.RepoWrite,
                _ => null,
            };
        }
    }
}