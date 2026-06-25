
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseUserRole
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
    public static class CreateOrganizationsResourceGroupsUsersResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseUserRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseUserRole.Admin => "admin",
                CreateOrganizationsResourceGroupsUsersResponseUserRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsUsersResponseUserRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsUsersResponseUserRole.Read => "read",
                CreateOrganizationsResourceGroupsUsersResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsUsersResponseUserRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsUsersResponseUserRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsUsersResponseUserRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsUsersResponseUserRole.Read,
                "write" => CreateOrganizationsResourceGroupsUsersResponseUserRole.Write,
                _ => null,
            };
        }
    }
}