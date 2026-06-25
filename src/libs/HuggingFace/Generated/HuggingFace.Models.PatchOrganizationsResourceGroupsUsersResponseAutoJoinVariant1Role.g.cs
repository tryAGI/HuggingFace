
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role
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
    public static class PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Admin => "admin",
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Contributor => "contributor",
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Read => "read",
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Admin,
                "contributor" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.NoAccess,
                "read" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Read,
                "write" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}