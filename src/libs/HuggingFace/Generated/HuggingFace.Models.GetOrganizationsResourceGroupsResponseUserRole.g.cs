
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseUserRole
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
    public static class GetOrganizationsResourceGroupsResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseUserRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseUserRole.Admin => "admin",
                GetOrganizationsResourceGroupsResponseUserRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseUserRole.NoAccess => "no_access",
                GetOrganizationsResourceGroupsResponseUserRole.Read => "read",
                GetOrganizationsResourceGroupsResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseUserRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseUserRole.Contributor,
                "no_access" => GetOrganizationsResourceGroupsResponseUserRole.NoAccess,
                "read" => GetOrganizationsResourceGroupsResponseUserRole.Read,
                "write" => GetOrganizationsResourceGroupsResponseUserRole.Write,
                _ => null,
            };
        }
    }
}