
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseUserOrgRole
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
    public static class CreateOrganizationsResourceGroupsUsersResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseUserOrgRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Admin => "admin",
                CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Read => "read",
                CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Read,
                "write" => CreateOrganizationsResourceGroupsUsersResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}