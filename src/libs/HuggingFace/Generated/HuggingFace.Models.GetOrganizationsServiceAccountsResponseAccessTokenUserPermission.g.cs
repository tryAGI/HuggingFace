
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsResponseAccessTokenUserPermission
    {
        /// <summary>
        ///
        /// </summary>
        UserGatedReposRequestsWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsServiceAccountsResponseAccessTokenUserPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsResponseAccessTokenUserPermission value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsResponseAccessTokenUserPermission.UserGatedReposRequestsWrite => "user.gated-repos-requests.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsResponseAccessTokenUserPermission? ToEnum(string value)
        {
            return value switch
            {
                "user.gated-repos-requests.write" => GetOrganizationsServiceAccountsResponseAccessTokenUserPermission.UserGatedReposRequestsWrite,
                _ => null,
            };
        }
    }
}