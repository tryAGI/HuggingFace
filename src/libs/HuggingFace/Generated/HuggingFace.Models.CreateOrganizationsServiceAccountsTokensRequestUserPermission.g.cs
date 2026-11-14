
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTokensRequestUserPermission
    {
        /// <summary>
        ///
        /// </summary>
        UserGatedReposRequestsWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationsServiceAccountsTokensRequestUserPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTokensRequestUserPermission value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTokensRequestUserPermission.UserGatedReposRequestsWrite => "user.gated-repos-requests.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTokensRequestUserPermission? ToEnum(string value)
        {
            return value switch
            {
                "user.gated-repos-requests.write" => CreateOrganizationsServiceAccountsTokensRequestUserPermission.UserGatedReposRequestsWrite,
                _ => null,
            };
        }
    }
}