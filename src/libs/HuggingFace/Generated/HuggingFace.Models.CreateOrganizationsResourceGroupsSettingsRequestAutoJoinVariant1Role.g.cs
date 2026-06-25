
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role
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
    public static class CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Read => "read",
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.NoAccess,
                "read" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}