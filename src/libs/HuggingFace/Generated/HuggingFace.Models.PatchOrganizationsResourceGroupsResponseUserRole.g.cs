
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseUserRole
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
    public static class PatchOrganizationsResourceGroupsResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseUserRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseUserRole.Admin => "admin",
                PatchOrganizationsResourceGroupsResponseUserRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsResponseUserRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsResponseUserRole.Read => "read",
                PatchOrganizationsResourceGroupsResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsResponseUserRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsResponseUserRole.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsResponseUserRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsResponseUserRole.Read,
                "write" => PatchOrganizationsResourceGroupsResponseUserRole.Write,
                _ => null,
            };
        }
    }
}