
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole
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
    public static class CreateOrganizationsResourceGroupsUsersResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Admin => "admin",
                CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Inherit => "inherit",
                CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Read => "read",
                CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Contributor,
                "inherit" => CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Inherit,
                "no_access" => CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Read,
                "write" => CreateOrganizationsResourceGroupsUsersResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}