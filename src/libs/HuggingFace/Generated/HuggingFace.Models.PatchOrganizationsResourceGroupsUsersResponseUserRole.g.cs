
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseUserRole
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
    public static class PatchOrganizationsResourceGroupsUsersResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseUserRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseUserRole.Admin => "admin",
                PatchOrganizationsResourceGroupsUsersResponseUserRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsUsersResponseUserRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsUsersResponseUserRole.Read => "read",
                PatchOrganizationsResourceGroupsUsersResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsUsersResponseUserRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsUsersResponseUserRole.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsUsersResponseUserRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsUsersResponseUserRole.Read,
                "write" => PatchOrganizationsResourceGroupsUsersResponseUserRole.Write,
                _ => null,
            };
        }
    }
}