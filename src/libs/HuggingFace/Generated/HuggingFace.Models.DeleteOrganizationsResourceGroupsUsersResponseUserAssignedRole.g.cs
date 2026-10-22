
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Admin => "admin",
                DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Contributor => "contributor",
                DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Inherit => "inherit",
                DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.NoAccess => "no_access",
                DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Read => "read",
                DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Admin,
                "contributor" => DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Contributor,
                "inherit" => DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Inherit,
                "no_access" => DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.NoAccess,
                "read" => DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Read,
                "write" => DeleteOrganizationsResourceGroupsUsersResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}