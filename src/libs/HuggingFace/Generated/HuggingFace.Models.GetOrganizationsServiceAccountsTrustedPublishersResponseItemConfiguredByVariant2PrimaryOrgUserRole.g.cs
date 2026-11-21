
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Contributor,
        /// <summary>
        ///
        /// </summary>
        NoAccess,
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
    public static class GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Admin => "admin",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Read => "read",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Read,
                "write" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}