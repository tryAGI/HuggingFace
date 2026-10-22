
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole
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
    public static class PatchOrganizationsResourceGroupsUsersResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Admin => "admin",
                PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Inherit => "inherit",
                PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Read => "read",
                PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Contributor,
                "inherit" => PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Inherit,
                "no_access" => PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Read,
                "write" => PatchOrganizationsResourceGroupsUsersResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}