
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseUserRole
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
    public static class CreateOrganizationsResourceGroupsSettingsResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseUserRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseUserRole.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsResponseUserRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsResponseUserRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsSettingsResponseUserRole.Read => "read",
                CreateOrganizationsResourceGroupsSettingsResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsResponseUserRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsResponseUserRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsSettingsResponseUserRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsSettingsResponseUserRole.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsResponseUserRole.Write,
                _ => null,
            };
        }
    }
}