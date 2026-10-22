
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole
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
        Inherit,
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
    public static class CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Inherit => "inherit",
                CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Read => "read",
                CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Contributor,
                "inherit" => CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Inherit,
                "no_access" => CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}