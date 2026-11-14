
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole
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
    public static class GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Admin => "admin",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Read => "read",
                GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Read,
                "write" => GetSettingsTrustedPublishersResponseItemConfiguredByVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}