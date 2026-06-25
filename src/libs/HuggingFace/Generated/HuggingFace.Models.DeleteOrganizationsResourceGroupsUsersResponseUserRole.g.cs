
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseUserRole
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseUserRole value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseUserRole.Admin => "admin",
                DeleteOrganizationsResourceGroupsUsersResponseUserRole.Contributor => "contributor",
                DeleteOrganizationsResourceGroupsUsersResponseUserRole.NoAccess => "no_access",
                DeleteOrganizationsResourceGroupsUsersResponseUserRole.Read => "read",
                DeleteOrganizationsResourceGroupsUsersResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DeleteOrganizationsResourceGroupsUsersResponseUserRole.Admin,
                "contributor" => DeleteOrganizationsResourceGroupsUsersResponseUserRole.Contributor,
                "no_access" => DeleteOrganizationsResourceGroupsUsersResponseUserRole.NoAccess,
                "read" => DeleteOrganizationsResourceGroupsUsersResponseUserRole.Read,
                "write" => DeleteOrganizationsResourceGroupsUsersResponseUserRole.Write,
                _ => null,
            };
        }
    }
}