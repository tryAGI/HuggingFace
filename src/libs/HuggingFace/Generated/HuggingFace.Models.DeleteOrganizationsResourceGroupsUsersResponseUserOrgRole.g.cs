
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Admin => "admin",
                DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Contributor => "contributor",
                DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.NoAccess => "no_access",
                DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Read => "read",
                DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Admin,
                "contributor" => DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Contributor,
                "no_access" => DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.NoAccess,
                "read" => DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Read,
                "write" => DeleteOrganizationsResourceGroupsUsersResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}