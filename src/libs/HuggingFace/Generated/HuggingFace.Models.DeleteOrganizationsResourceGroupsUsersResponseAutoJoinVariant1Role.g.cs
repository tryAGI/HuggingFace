
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Admin => "admin",
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Contributor => "contributor",
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.NoAccess => "no_access",
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Read => "read",
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Admin,
                "contributor" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Contributor,
                "no_access" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.NoAccess,
                "read" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Read,
                "write" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}