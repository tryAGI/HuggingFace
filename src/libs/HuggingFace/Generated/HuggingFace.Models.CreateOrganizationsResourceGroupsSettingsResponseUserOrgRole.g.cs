
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole
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
    public static class CreateOrganizationsResourceGroupsSettingsResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Read => "read",
                CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}