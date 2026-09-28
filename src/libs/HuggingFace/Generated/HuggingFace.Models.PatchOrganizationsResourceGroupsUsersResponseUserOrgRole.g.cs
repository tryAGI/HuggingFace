
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseUserOrgRole
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
    public static class PatchOrganizationsResourceGroupsUsersResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseUserOrgRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Admin => "admin",
                PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Read => "read",
                PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Read,
                "write" => PatchOrganizationsResourceGroupsUsersResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}