
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsServiceAccountsResponseAccessTokenRole
    {
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsServiceAccountsResponseAccessTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsResponseAccessTokenRole value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsResponseAccessTokenRole.FineGrained => "fineGrained",
                GetOrganizationsServiceAccountsResponseAccessTokenRole.Read => "read",
                GetOrganizationsServiceAccountsResponseAccessTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsResponseAccessTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => GetOrganizationsServiceAccountsResponseAccessTokenRole.FineGrained,
                "read" => GetOrganizationsServiceAccountsResponseAccessTokenRole.Read,
                "write" => GetOrganizationsServiceAccountsResponseAccessTokenRole.Write,
                _ => null,
            };
        }
    }
}