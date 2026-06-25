
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersRequestRole
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
    public static class PatchOrganizationsResourceGroupsUsersRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersRequestRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersRequestRole.Admin => "admin",
                PatchOrganizationsResourceGroupsUsersRequestRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsUsersRequestRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsUsersRequestRole.Read => "read",
                PatchOrganizationsResourceGroupsUsersRequestRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsUsersRequestRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsUsersRequestRole.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsUsersRequestRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsUsersRequestRole.Read,
                "write" => PatchOrganizationsResourceGroupsUsersRequestRole.Write,
                _ => null,
            };
        }
    }
}