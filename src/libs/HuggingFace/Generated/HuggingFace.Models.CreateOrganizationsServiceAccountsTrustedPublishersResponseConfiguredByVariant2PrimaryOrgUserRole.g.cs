
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole
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
    public static class CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Read => "read",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Read,
                "write" => CreateOrganizationsServiceAccountsTrustedPublishersResponseConfiguredByVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}