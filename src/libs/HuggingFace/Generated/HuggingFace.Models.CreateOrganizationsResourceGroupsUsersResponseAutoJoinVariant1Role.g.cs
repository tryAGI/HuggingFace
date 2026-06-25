
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role
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
    public static class CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Admin => "admin",
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Read => "read",
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.NoAccess,
                "read" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Read,
                "write" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}