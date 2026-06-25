
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role
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
    public static class CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Read => "read",
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.NoAccess,
                "read" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}