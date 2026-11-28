
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsServiceAccountsTokensRequestUserPermission
    {
        /// <summary>
        ///
        /// </summary>
        UserGatedReposRequestsWrite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchOrganizationsServiceAccountsTokensRequestUserPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsServiceAccountsTokensRequestUserPermission value)
        {
            return value switch
            {
                PatchOrganizationsServiceAccountsTokensRequestUserPermission.UserGatedReposRequestsWrite => "user.gated-repos-requests.write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsServiceAccountsTokensRequestUserPermission? ToEnum(string value)
        {
            return value switch
            {
                "user.gated-repos-requests.write" => PatchOrganizationsServiceAccountsTokensRequestUserPermission.UserGatedReposRequestsWrite,
                _ => null,
            };
        }
    }
}